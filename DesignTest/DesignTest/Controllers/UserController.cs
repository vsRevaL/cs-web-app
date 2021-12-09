using DesignTest.Models;
using DesignTest.Models.CustomValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesignTest.Controllers
{
    public class UserController : Controller
    {
        private CarPoolDB _db = new CarPoolDB();

        #region IAction methods

        public IActionResult AddBookingUser(string routeIdStr)
        {
            int routeId;
            bool isInt = int.TryParse(routeIdStr, out routeId);

            if (!Authenticate() || !isInt)
            {
                return Redirect("~/Home");
            }

            Route selectedRoute = _db.Routes.Include(x => x.Bookings).FirstOrDefault(x => x.Id == routeId);
            if (selectedRoute == null)
            {
                return Redirect("~/Home");
            }

            UserHelper.SelectedRoute = selectedRoute;
            ViewBag.SelectedRoute = UserHelper.SelectedRoute;

            string username = HttpContext.Session.GetString("LoggedIn");
            Useer loggedUser = _db.Useers.FirstOrDefault(x => x.Username == username);
            loggedUser.ConfirmPassword = loggedUser.Password;
            if (loggedUser == null)
            {
                return Redirect("~/Home");
            }

            return View(loggedUser);
        }

        [HttpPost]
        public IActionResult AddBookingUser(Useer postUser)
        {
            ViewBag.SelectedRoute = UserHelper.SelectedRoute;
            AuthState.State = States.LOG;
            ModelState.Remove("ConfirmPassword");
            ModelState.Remove("Username");
            if (!ModelState.IsValid)
            {
                return View(postUser);
            }

            Useer currentUser = _db.Useers.FirstOrDefault(x => x.Id == postUser.Id);

            if (currentUser == null)
            {
                return Redirect("~/Home");
            }

            currentUser.Name = postUser.Name;
            currentUser.Email = postUser.Email;
            currentUser.Address = postUser.Address;
            currentUser.Phone = postUser.Phone;

            Booking newBooking = new Booking();
            newBooking.UserId = postUser.Id;
            newBooking.RouteId = UserHelper.SelectedRoute.Id;
            _db.Add(newBooking);
            _db.SaveChanges();

            return Redirect("~/Home/Success?message=Foglalás sikeresen megtörtént!");
        }

        public IActionResult MyBookings()
        {
            if (!Authenticate())
            {
                return Redirect("~/Home/Index");
            }

            string username = HttpContext.Session.GetString("LoggedIn");
            Useer currentUser = _db.Useers.Include(x => x.Bookings)
                                           .ThenInclude(x => x.Route)
                                            .FirstOrDefault(x => x.Username == username);


            if (currentUser == null)
            {
                return Redirect("~/Home/Index");
            }

            var myBookings = currentUser.Bookings.OrderBy(x => x.Route.When);

            return View(myBookings);
        }

        public IActionResult DeleteBooking(string bookingIdStr)
        {
            int bookingId;
            bool isInt = int.TryParse(bookingIdStr, out bookingId);

            if (!Authenticate() || !isInt)
            {
                return Redirect("~/Home");
            }

            Booking goingToBeDeleted = _db.Bookings.FirstOrDefault(x => x.Id == bookingId);
            if (goingToBeDeleted == null)
            {
                return RedirectToAction("~/Home");
            }
            _db.Remove(goingToBeDeleted);
            _db.SaveChanges();

            return RedirectToAction("MyBookings");
        }

        #endregion

        private bool Authenticate()
        {
            return HttpContext.Session.GetString("LoggedIn") != null;
        }
    }
}
