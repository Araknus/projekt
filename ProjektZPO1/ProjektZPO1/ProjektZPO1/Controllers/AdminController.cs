using ProjektZPO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektZPO1.Controllers
{
    public class AdminController : Controller
    {
        DatabaseEntities db = new DatabaseEntities();

        public ActionResult Index()
        {
            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult CreatePupil(Pupil pupil)
        {
            try
            {

                var user = new User();

                user.Login = pupil.FirstName.Substring(0, 3) + pupil.LastName.Substring(0, 3);
                user.Password = "pass";

                user = db.Users.Add(user);

                pupil.IdLoginData = user.Id;

                pupil = db.Pupils.Add(pupil);
                db.SaveChanges();


                ViewBag.isDoneU = "ok";
                ViewBag.Message = "Uczeń " + pupil.FirstName + " " + pupil.LastName + " został dodany.";

            }
            catch (Exception)
            {
                ViewBag.isDoneU = "notOk";
                ViewBag.Message = "Uczeń " + pupil.FirstName + " " + pupil.LastName + " nie został dodany.";
            }


            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        public ActionResult PupilEdit(int id)
        {
            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View(db.Pupils.Where(x => x.Id == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult PupilEditSubmit(Pupil pupil)
        {
            db.Entry(pupil).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;
            
            return View("Index");
        }

        public ActionResult SelectPupilsByClassRoom(int id)
        {
            try
            {
                var pupils = db.ClassRooms.Find(id).Pupils;

                if (pupils != null)
                {
                    return View("PupilsList", pupils);
                }
            }
            catch (Exception)
            {

            }

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        [HttpPost]
        public ActionResult CreateTeacher(Teacher teacher)
        {
            try
            {
                var user = new User();

                user.Login = teacher.FirstName.Substring(0, 3) + teacher.LastName.Substring(0, 3);
                user.Password = "pass";
                user.IdRole = 1;

                user = db.Users.Add(user);

                teacher.IdLoginData = user.Id;

                teacher = db.Teachers.Add(teacher);
                db.SaveChanges();


                ViewBag.isDoneU = "ok";
                ViewBag.Message = "Nauczyciel " + teacher.FirstName + " " + teacher.LastName + " został dodany.";

            }
            catch (Exception)
            {
                ViewBag.isDoneN = "notOk";
                ViewBag.Message = "Nauczyciel " + teacher.FirstName + " " + teacher.LastName + " nie został dodany.";
            }

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        public ActionResult TeacherEdit(int id)
        {
            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View(db.Teachers.Where(x => x.Id == id).FirstOrDefault());
        }

        public ActionResult TeacherEditSubmit(Teacher teacher)
        {
            db.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        public ActionResult SelectTeacherBySubject(int id)
        {
            try
            {
                var teachers = db.Teachers.Where(x => x.IdSubject == id);
                if (teachers != null)
                {
                    return View("TeachersList", teachers);
                }
            }
            catch (Exception)
            {
                
            }

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        public ActionResult CreateSubject(Subject subject)
        {
            try
            {
                db.Subjects.Add(subject);
                db.SaveChanges();

                ViewBag.isDoneU = "ok";
                ViewBag.Message = "Przemiot " + subject.Name + " został dodany.";
            }
            catch (Exception)
            {
                ViewBag.isDoneU = "notOk";
                ViewBag.Message = "Przemiot " + subject.Name + " nie został dodany.";
            }

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        public ActionResult SubjectEdit(int id)
        {
            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("SubjectEdit", db.Subjects.Where(x => x.Id == id).FirstOrDefault());
        }

        public ActionResult SubjectEditSubmit(Subject subject)
        {
            db.Entry(subject).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        public ActionResult CreateClassRoom(ClassRoom classRoom)
        {
            try
            {
                var classTmp = db.ClassRooms.Add(classRoom);
                db.SaveChanges();
                ViewBag.isDoneU = "ok";
                ViewBag.Message = "Klasa " + classRoom.Name + " została dodana.";
            }
            catch (Exception)
            {
                ViewBag.isDoneU = "notOk";
                ViewBag.Message = "Klasa " + classRoom.Name + " został dodana.";
            }

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        public ActionResult ClassRoomEdit(int id)
        {
            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View(db.ClassRooms.Where(x => x.Id == id).FirstOrDefault());
        }

        public ActionResult ClassRoomEditSubmit(ClassRoom classRoom)
        {
            db.Entry(classRoom).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        //Users Deletion

        public ActionResult Delete(int id)
        {
            var user = db.Users.Find(id);

            db.Users.Remove(user);
            db.SaveChanges();

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        //ClassRooms Deletion

        public ActionResult DeleteClassRoom(int id)
        {
            var classRoom = db.ClassRooms.Find(id);

            db.ClassRooms.Remove(classRoom);
            db.SaveChanges();

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        //Subject Deletion

        public ActionResult DeleteSubject(int id)
        {
            var subject = db.Subjects.Find(id);

            db.Subjects.Remove(subject);
            db.SaveChanges();

            ViewBag.ClassRoomsVB = db.ClassRooms;
            ViewBag.SubjectsVB = db.Subjects;

            return View("Index");
        }

        //List Views

        public ActionResult PupilsList()
        {
            return View(db.Pupils.ToList());
        }

        public ActionResult TeachersList()
        {
            return View(db.Teachers.ToList());
        }

        public ActionResult ClassRoomsList()
        {
            return View(db.ClassRooms.ToList());
        }

        public ActionResult SubjectsList()
        {
            return View(db.Subjects.ToList());
        }

    }
}