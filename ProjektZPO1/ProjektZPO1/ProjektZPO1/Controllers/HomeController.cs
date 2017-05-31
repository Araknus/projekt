using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace ProjektZPO1.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User userModel)
        {
            using (Models.DatabaseEntities db = new Models.DatabaseEntities())
            {
                var userDetail = db.Users.Where(x => x.Login == userModel.Login && x.Password == userModel.Password)
                    .FirstOrDefault();


                if (ModelState.IsValid)
                {
                    if (userDetail != null)
                        
                    {
                        Session["Id"] = userDetail.Id;
                        Session["UserType"] = userDetail.IdRole;

                        if (userDetail.IdRole == 0)
                        {
                            var tmp = userDetail.Pupils.Where(x => x.IdLoginData == userDetail.Id).FirstOrDefault();
                            Session["UserName"] = tmp.FirstName + " " + tmp.LastName;
                        }
                        else if (userDetail.IdRole == 1)
                        {
                            var tmp = userDetail.Teachers.Where(x => x.IdLoginData == userDetail.Id).FirstOrDefault();
                            Session["UserName"] = tmp.FirstName + " " + tmp.LastName;
                        }

                        return RedirectToAction("Index");
                    }
                }

            }

            return null;
        }
    }
}