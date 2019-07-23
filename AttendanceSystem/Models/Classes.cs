namespace AttendanceSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classes
    {
        [Required]
        [StringLength(30)]
        public string Class_Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        public int? Teacher_No { get; set; }

        public int Id { get; set; }
    }
}
