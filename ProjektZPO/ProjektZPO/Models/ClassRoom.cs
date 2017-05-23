using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektZPO.Models
{
    public class ClassRoom
    {
        private List<Pupil> pupils;
        private string className;
        private string description;

        public ClassRoom(string className, string description)
        {
            this.className = className;
            this.description = description;
        }
    }
}