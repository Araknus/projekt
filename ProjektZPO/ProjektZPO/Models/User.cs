using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektZPO.Models
{
    public abstract class User
    {
        protected long id;
        protected string idNumber;
        protected string firstName;
        protected string surname;
        protected string eMail;
        protected AccountState state;
        protected AccountType type;

        public long Id { get { return this.id; } set { this.id = value; } }
        public string IdNumber { get { return this.idNumber; } set { this.idNumber = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string Surname { get { return this.surname; } set { this.surname = value; } }
        public string EMail { get { return this.eMail; } set { this.eMail = value; } }
        public AccountState State { get { return this.state; } set { this.state = value; } }

        public User(long id, string idNumber, string firstName, string surname, string eMail, AccountState state, AccountType type)
        {
            this.id = id;
            this.idNumber = idNumber;
            this.firstName = firstName;
            this.surname = surname;
            this.eMail = eMail;
            this.state = state;
            this.type = type;
        }

        public bool ChangeEMail(string eMail)
        {
            this.eMail = eMail;

            if (this.eMail == eMail)
            {
                return true;
            }

            return false;
        }

        public bool ChangeAccountState(AccountState accountState)
        {
            this.state = accountState;

            if (this.state == accountState)
            {
                return true;
            }

            return false;
        }
    }
}