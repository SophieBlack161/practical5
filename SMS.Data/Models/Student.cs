using System;
using System.ComponentModel.DataAnnotations;//needed to allow required annotations

namespace SMS.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Course { get; set; }
        
        [Range (13,90)]
        public int Age { get; set; } 
        
        [Range (0,100)]
        public double Grade { get; set; }
        
        [Url]
        public string PhotoUrl { get; set; }     

        // Read-Only property - not stored in database
        public string Classification => Classify();

        // private method to calculate the classification
        private string Classify() {
            if (Grade < 50)
            {
                return "Fail";
            }
            else if (Grade >=50 && Grade < 70)
            {
                return "Pass";
            }
            else if (Grade >=70 && Grade < 80)
            {
                return "Commendation";
            }
            else
            {
                return "Distinction";
            }
        }

    }
}