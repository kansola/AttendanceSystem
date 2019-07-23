namespace AttendanceSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Class_Id { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Date_Attended { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Student_No { get; set; }
    }
}
