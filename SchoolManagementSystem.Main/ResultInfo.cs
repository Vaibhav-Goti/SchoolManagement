//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Main
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResultInfo
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public decimal HalfYearly { get; set; }
        public decimal Yearly { get; set; }
    
        public virtual SubjectInfo SubjectInfo { get; set; }
        public virtual StudentInfo StudentInfo { get; set; }
    }
}