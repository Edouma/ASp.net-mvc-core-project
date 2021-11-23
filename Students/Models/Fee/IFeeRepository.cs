using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models.Fees
{
   public interface IFeeRepository
    {

        Fee GetRegister(int id);
        IEnumerable<Fee> GetAllRegister();
        Fee Add(Fee register);
        Fee Update(Fee registerChanges);
        Fee Delete(int id);
        IEnumerable<FeeBalance> Student_Fee();
    }
}
