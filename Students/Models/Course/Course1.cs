using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class Course1
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; }


        public List <student> student { get; set; }
    }
}
