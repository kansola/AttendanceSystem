namespace AttendanceSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teacher
    {
        [Column(TypeName = "numeric")]
        public decimal Teacher_No { get; set; }

        [Required]
        [StringLength(50)]
        public string Teacher_Name { get; set; }

        [StringLength(11)]
        public string Phone_No { get; set; }

        [StringLength(50)]
        public string Email_Address { get; set; }

        public int Id { get; set; }
    }
}
