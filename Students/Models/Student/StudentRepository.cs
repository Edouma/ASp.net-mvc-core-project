using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class StudentRepository : IStudentsRepository
    {
        private readonly StudentDBContext context;
      

        public StudentRepository(StudentDBContext context)
        {
            this.context = context;
        }
        public student Add(student register)
        {
            context.students.Add(register);
            context.SaveChanges();
            return register;
        }
        public student Delete(int id)
        {
            student Student = context.students.Find(id);

            if(Student != null)
            {
                context.students.Remove(Student);
                context.SaveChanges();
            }
            return Student;
        }

        public IEnumerable<student> GetAllRegister()
        {
            return context.students;
        }

        public student GetRegister(int id)
        {
            return context.students.Find(id);
        }
 
        public student Update(student registerChanges)
        {
            var Students = context.students.Attach(registerChanges);
            Students.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return registerChanges;
        }
    }
}
