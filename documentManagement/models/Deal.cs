using System;
using System.Collections.Generic;

namespace documentManagement.models
{
    public class Deal
    {
        public int id { get; set; }
        public DateTime date { get; set; }  
        public decimal totalCost { get; set; }
        public PFace physicalFace { get; set; }
        public List<EducationProgram> educationPrograms { get; set; }

        public Deal() { }
        public Deal(int id, DateTime date, decimal totalCost, PFace face, List<EducationProgram> educationPrograms)
        {
            this.id = id;
            this.date = date;
            this.totalCost = totalCost;
            this.physicalFace = face;
            this.educationPrograms = educationPrograms;
        }
    }
}
