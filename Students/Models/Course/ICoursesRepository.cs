using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models.Course
{
    public interface ICoursesRepository
    {
        Course1 GetRegister(int id);
        IEnumerable<Course1> GetAllRegister();
        Course1 Add(Course1 register);
        Course1 Update(Course1 registerChanges);
        Course1 Delete(int id);
    }
}
