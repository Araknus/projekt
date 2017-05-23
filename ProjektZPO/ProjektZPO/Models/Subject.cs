using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektZPO.Models
{
    public class Subject
    {
        private Teacher teacher;
        private string description;

        public Subject(Teacher teacher, string className, string description)
        {
            this.teacher = teacher;
            this.description = description;
        }
    }
}