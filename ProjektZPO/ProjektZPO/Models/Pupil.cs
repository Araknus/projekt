using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektZPO.Models
{
    public class Pupil : User
    {
        private List<Grade> grades;

        public List<Grade> Grades { get { return this.grades; } }

        public Pupil(long id, string idNumber, string firstName, string surname, string eMail, AccountState state) 
            : base(id, idNumber, firstName, surname, eMail, state, AccountType.Pupil)
        {
            this.grades = new List<Grade>();

        }
    }
}