//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int CourseID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
    }
}
