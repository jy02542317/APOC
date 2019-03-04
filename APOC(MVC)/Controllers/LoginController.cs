using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;

namespace APOC_MVC_.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ViewData["LoginSuccess"] = this.TempData["LoginSuccess"];
            return View();
        }

        public ActionResult Login()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            User user = new User();
            user.LoginName = username;
            user.Password = password;
            UserBLL bo = new UserBLL();
            if (bo.Login(user))
            {
                this.TempData["LoginSuccess"] = "";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                this.TempData["LoginSuccess"] = "登陆失败!";
                return RedirectToAction("Index", "Login");
            }
        }
    }
}