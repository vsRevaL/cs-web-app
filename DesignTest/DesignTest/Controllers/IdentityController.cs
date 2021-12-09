using DesignTest.Models;
using DesignTest.Models.CustomValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace DesignTest.Controllers
{
    public class IdentityController : Controller
    {
        private CarPoolDB _db = new CarPoolDB();

        #region IAction methods

        public IActionResult Login()
        {
            AuthState.State = States.LOG;
            if (Authenticate())
            {
                return Redirect("~/Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(Useer postUser)
        {
            AuthState.State = States.LOG;
            if (postUser.Password != postUser.ConfirmPassword)
            {
                return View(postUser);
            }

            if (postUser.Username != null && postUser.Username.Length >= 1 && postUser.Username.StartsWith('$'))
            {
                return View(postUser);
            }

            foreach (Useer user in _db.Useers)
            {
                if (user.Username == postUser.Username)
                {
                    if (user.Password == postUser.Password)
                    {
                        HttpContext.Session.SetString("LoggedIn", user.Username);
                        return Redirect("~/Home");
                    }
                    else
                    {
                        return View(postUser);
                    }
                }
            }

            return View(postUser);
        }

        public IActionResult Register()
        {
            AuthState.State = States.REG;
            if (Authenticate())
            {
                return Redirect("~/Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Register(Useer postUser)
        {
            AuthState.State = States.REG;
            if (!ModelState.IsValid || postUser.Username.StartsWith('$'))
            {
                return View(postUser);
            }

            _db.Add(postUser);
            _db.SaveChanges();

            return Redirect("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("~/Home");
        }

        #endregion

        private bool Authenticate()
        {
            return HttpContext.Session.GetString("LoggedIn") != null;
        }
    }
}