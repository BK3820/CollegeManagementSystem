//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class students_info
    {
        public int student_id { get; set; }
        public string reg_no { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public System.DateTime date_of_birth { get; set; }
        public string gender { get; set; }
        public Nullable<int> faculty { get; set; }
        public Nullable<int> academic_status { get; set; }
        public Nullable<int> batch { get; set; }
        public string blood_group { get; set; }
        public string email { get; set; }
        public Nullable<int> student_status { get; set; }
    
        public virtual staff_info staff_info { get; set; }
        public virtual student_batches student_batches { get; set; }
    }
}
