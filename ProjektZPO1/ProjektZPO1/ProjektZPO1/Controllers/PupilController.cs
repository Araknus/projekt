using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektZPO1.Models;

namespace ProjektZPO1.Controllers
{
    public class PupilController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();

        public ActionResult Index()
        {
            return View();
        }

        //NIEDZIALA
        public ActionResult FriendsList()
        {
            var tmp = db.Pupils.Where(x => x.IdClassRoom == db.Pupils.Find(Session["Id"]).IdClassRoom);
            return View(tmp);
        }
    }
}