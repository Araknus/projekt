//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektZPO1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int Id { get; set; }
        public Nullable<int> Value { get; set; }
        public string Description { get; set; }
        public int IdPupil { get; set; }
        public int IdTeacher { get; set; }
        public int IdSubject { get; set; }
    
        public virtual Pupil Pupil { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
