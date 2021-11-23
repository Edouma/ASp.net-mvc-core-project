using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models.Course
{
    public class CourseRepository : ICoursesRepository
              
    {
        private readonly StudentDBContext context;

        public CourseRepository(StudentDBContext context)
        {
            this.context = context;
        }

        public Course1 Add(Course1 register)
        {
            context.courses.Add(register);
            context.SaveChanges();
            return register;
        }

        public Course1 Delete(int id)
        {
            Course1 course = context.courses.Find(id);

            if (course != null)
            {
                context.courses.Remove(course);
                context.SaveChanges();
            }
            return course;
        }

        public IEnumerable<Course1> GetAllRegister()
        {
            return context.courses;
        }

        public Course1 GetRegister(int id)
        {
            return context.courses.Find(id);
        }

        public Course1 Update(Course1 registerChanges)
        {
            var courses = context.courses.Attach(registerChanges);
            courses.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return registerChanges;
        }
    }
}
