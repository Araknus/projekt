using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektZPO.Models
{
    public class Admin : User
    {
        public Admin(long id, string idNumber, string firstName, string surname, string eMail, AccountState state)
            : base(id, idNumber, firstName, surname, eMail, state, AccountType.Admin)
        {
        }
    }
}