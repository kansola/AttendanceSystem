namespace AttendanceSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal Student_No { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Student_Name { get; set; }

        [StringLength(11)]
        public string Phone_No { get; set; }

        [StringLength(20)]
        public string Email_address { get; set; }

        [StringLength(200)]
        public string Thumb_Print { get; set; }
    }
}
