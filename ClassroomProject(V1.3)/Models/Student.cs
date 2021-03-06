//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassroomProject_V1._3_.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Discontinuities = new HashSet<Discontinuity>();
            this.Grades = new HashSet<Grade>();
            this.Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public Nullable<int> Class_Id { get; set; }
        public Nullable<int> Group_Id { get; set; }
        public string TCno { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Phone { get; set; }
        public string eMail { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> DateOfJoin { get; set; }
        public Nullable<System.DateTime> DateOfLeave { get; set; }
        public string Address { get; set; }
        public string ParentName { get; set; }
        public string ParentPhone1 { get; set; }
        public string ParentPhone2 { get; set; }
        public Nullable<bool> ParentGender { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }

        public string LoginErrorMessage { get; set; }

        public virtual Class Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discontinuity> Discontinuities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
