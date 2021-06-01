using System;
using System.Collections.Generic;
using System.Text;

namespace TqlBootcamp.Models
{
    public class AssessmentScore
    {
        public int Id { get; set; }
        public int ActualScore { get; set; }
        //foreign key
        public int StudentId { get; set; }
        //virtual prop only in the class 
        public virtual Student Student { get; set; }
        public int AssessmentID { get; set; }
        public virtual Assessment Assessment { get; set; }

        //def const
        public AssessmentScore()
        {
        }
    }
}
