using DesignTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignTest.Controllers
{
    public class AdminController : Controller
    {
        private CarPoolDB _db = new CarPoolDB();

        #region IAction methods

        public IActionResult Diagram()
        {
            if (!Authenticate())
            {
                return Redirect("~/Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Diagram(DateTime fromWhen, DateTime untilWhen, string selectpicker)
        {
            if (!Authenticate() || String.IsNullOrEmpty(selectpicker))
            {
                return Redirect("~/Home");
            }

            if (DateTime.Compare(fromWhen, DateTime.Parse("1900.01.01")) < 0)
            {
                fromWhen = DateTime.Parse("2000.01.01");
            }

            if (DateTime.Compare(untilWhen, DateTime.Parse("1900.01.01")) < 0)
            {
                untilWhen = DateTime.Now.AddYears(10);
            }

            Dictionary<string, int> map = new Dictionary<string, int>();

            if (selectpicker == "from")
            {
                foreach (Route route in _db.Routes.Include(x => x.Bookings).ThenInclude(x => x.User)
                                                .Where(x => (DateTime.Compare(x.When, fromWhen) >= 0 && DateTime.Compare(x.When, untilWhen) <= 0)))
                {
                    if (map.ContainsKey(route.FromCity))
                    {
                        map[route.FromCity] += route.Bookings.Count;
                    }
                    else
                    {
                        map.Add(route.FromCity, route.Bookings.Count);
                    }
                }
            }
            else if (selectpicker == "to")
            {
                foreach (Route route in _db.Routes.Include(x => x.Bookings).ThenInclude(x => x.User)
                                                .Where(x => (DateTime.Compare(x.When, fromWhen) >= 0 && DateTime.Compare(x.When, untilWhen) <= 0)))
                {
                    if (map.ContainsKey(route.ToCity))
                    {
                        map[route.ToCity] += route.Bookings.Count;
                    }
                    else
                    {
                        map.Add(route.ToCity, route.Bookings.Count);
                    }
                }
            }


            ViewBag.Map = map;

            return View();
        }

        public IActionResult EditRoute(string routeIdStr)
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

            return View(selectedRoute);
        }

        [HttpPost]
        public IActionResult EditRoute(Route postRoute)
        {
            ViewBag.SelectedRoute = UserHelper.SelectedRoute;
            
            if (!ModelState.IsValid)
            {
                return View(postRoute);
            }

            Route currentRoute = _db.Routes.FirstOrDefault(x => x.Id == postRoute.Id);

            if (currentRoute == null)
            {
                return Redirect("~/Home");
            }

            currentRoute.FromCity = postRoute.FromCity;
            currentRoute.ToCity = postRoute.ToCity;
            currentRoute.When = postRoute.When;
            currentRoute.Km = postRoute.Km;
            currentRoute.Seats = postRoute.Seats;

            _db.SaveChanges();

            return Redirect("~/Home/Success?message=Indukás sikeresen frissítve.");
        }

        public IActionResult AddNewRoute()
        {
            if (!Authenticate())
            {
                return Redirect("~/Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddNewRoute(Route postRoute)
        {
            if (!Authenticate())
            {
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View(postRoute);
            }

            _db.Add(postRoute);
            _db.SaveChanges();

            ViewBag.Success = "Új indulás sikeresen hozzáadva. ";
            return View();
        }

        #endregion 

        private bool Authenticate()
        {
            return HttpContext.Session.GetString("LoggedIn") != null && HttpContext.Session.GetString("LoggedIn") == "admin";
        }
    }
}
