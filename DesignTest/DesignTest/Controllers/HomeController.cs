using DesignTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DesignTest.Models.CustomValidation;

namespace DesignTest.Controllers
{
    public class HomeController : Controller
    {
        private CarPoolDB _db = new CarPoolDB();

        #region IAction methods

        public IActionResult Index()
        {
            HashSet<string> routesForSelectpicker = new HashSet<string>();
            foreach (Route item in _db.Routes.OrderBy(x => x.FromCity))
            {
                string currentRoute = item.FromCity + "➝" + item.ToCity;
                routesForSelectpicker.Add(currentRoute);
            }

            return View(routesForSelectpicker);
        }

        public IActionResult ListRoutes(string selectpicker, DateTime fromwhen)
        {
            if (DateTime.Compare(fromwhen, DateTime.Parse("2000.01.01")) < 0)
            {
                fromwhen = DateTime.Now;
            }

            var everyRoute = _db.Routes.Where(x => DateTime.Compare(x.When, fromwhen) > 0)
                                        .Include(x => x.Bookings)
                                          .OrderBy(x => x.When);

            if (string.IsNullOrEmpty(selectpicker) || selectpicker == "all")
            {
                return View(everyRoute);
            }
            
            string fromCity = "";
            string toCity = "";
            try
            {
                string[] cities = selectpicker.Split("➝");
                fromCity  = cities[0];
                toCity  = cities[1];
            }
            catch (IndexOutOfRangeException)
            {
                return View(everyRoute);
            }

            var filteredRoutes = _db.Routes.Where(x => (DateTime.Compare(x.When, fromwhen) > 0) &&
                                                  x.FromCity == fromCity && x.ToCity == toCity)
                                            .Include(x => x.Bookings).OrderBy(x => x.When);
            return View(filteredRoutes);
        }

        public IActionResult AddBookingHome(string routeIdStr)
        {
            int routeId;
            bool isInt = int.TryParse(routeIdStr, out routeId);

            if (!isInt)
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

            return View();
        }

        [HttpPost]
        public IActionResult AddBookingHome(Useer postUser)
        {
            ViewBag.SelectedRoute = UserHelper.SelectedRoute;
            AuthState.State = States.LOG;
            ModelState.Remove("ConfirmPassword");
            ModelState.Remove("Username");
            ModelState.Remove("Password");
            ModelState.Remove("Id");

            if (!ModelState.IsValid)
            {
                return View(postUser);
            }

            Random rand = new Random();
            int randUsername = rand.Next(999999999);
            postUser.Username = "$temp" + randUsername + DateTime.Now.ToString();
            int randPassword = rand.Next(999999999);
            postUser.Password = randPassword + DateTime.Now.ToString(); ;

            _db.Add(postUser);
            _db.SaveChanges();

            Useer userFromDb = _db.Useers.First(x => x.Username == postUser.Username);
            Booking newBooking = new Booking();
            newBooking.UserId = userFromDb.Id;
            newBooking.RouteId = UserHelper.SelectedRoute.Id;
            _db.Add(newBooking);
            _db.SaveChanges();

            return Redirect("~/Home/Success?message=Foglalás sikeresen megtörtént!");
        }

        public IActionResult Success(string message)
        {
            ViewBag.SuccessMessage = message;
            return View();
        }

        #endregion
    }
}
