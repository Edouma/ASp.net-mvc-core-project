using Students.Models.Fees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models      
{
    public class student
    {
        public int studentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Course { get; set; }


        public int? Course1Id { get; set; }

        public Course1 Course1 { get; set; }
        

        public Fee Fee { get; set; }
        


    }
}
