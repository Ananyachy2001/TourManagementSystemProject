using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TourManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Index(UserProfile objUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (DB_Entities db = new DB_Entities())
        //        {
        //            var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                Session["UserID"] = obj.UserId.ToString();
        //                Session["UserName"] = obj.UserName.ToString();
        //                return RedirectToAction("UserDashBoard");
        //            }

        //        }
        //    }
        //    return View(objUser);
        //}
        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}