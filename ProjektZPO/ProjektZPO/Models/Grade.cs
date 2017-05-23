using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektZPO.Models
{
    public class Grade
    {
        private long id;
        private Pupil pupil;
        private Teacher teacher;
        private Subject subject;
        private string description;
        private DateTime date;

        public Grade(long id, Pupil pupil, Teacher teacher, Subject subject, string description, DateTime date)
        {
            this.id = id;
            this.pupil = pupil;
            this.teacher = teacher;
            this.subject = subject;
            this.description = description;
            this.date = date;
        }
       
    }
}