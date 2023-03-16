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
    
    public partial class StudentInfo
    {
        public StudentInfo()
        {
            this.ResultInfoes = new HashSet<ResultInfo>();
            this.UserCredentials = new HashSet<UserCredential>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public decimal ContactNo { get; set; }
        public int SectionID { get; set; }
        public int ClassID { get; set; }
    
        public virtual ClassInfo ClassInfo { get; set; }
        public virtual ICollection<ResultInfo> ResultInfoes { get; set; }
        public virtual SectionInfo SectionInfo { get; set; }
        public virtual ICollection<UserCredential> UserCredentials { get; set; }
    }
}