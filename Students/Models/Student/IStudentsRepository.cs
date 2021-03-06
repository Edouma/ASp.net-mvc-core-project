using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public interface IStudentsRepository
    {
        student GetRegister(int id);
        IEnumerable<student> GetAllRegister();
        student Add(student register);
        student Update(student registerChanges);
        student Delete(int id);
    }
}
