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
    using System.ComponentModel.DataAnnotations;

    public class ManagementDTO
    {
        public Management ManagementData { get; set; }
        public List<Management> ManagementList { get; set; }
    }

    public partial class Management
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan� doldurman�z gerekiyor.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan� doldurman�z gerekiyor.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}
