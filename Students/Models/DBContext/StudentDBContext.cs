using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Students.Models.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Students.Models
{
    public class StudentDBContext : IdentityDbContext
        
    {
       
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }
        public DbSet<student> students { get; set; }

        
        public DbSet<Course1> courses { get; set; }

        public DbSet<Fee> Fees { get; set; }


    }
}
