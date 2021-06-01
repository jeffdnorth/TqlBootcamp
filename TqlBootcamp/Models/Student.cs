using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TqlBootcamp.Models
{
    public class Student
    {      //primary key cuz int
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        //above tell system by attribute they are not allowed to be null by required
        
        public string Firstname { get; set; }
        [Required, StringLength(50)]
        public string Lastname { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        //making them up for practice
        public decimal TargetSalary { get; set; }
        //allows to be null w question mark
        public bool? InBootcamp { get; set; }

        public virtual List<AssessmentScore> AssessmentScores { get; set; }
        public Student () { }

        


    }
}
