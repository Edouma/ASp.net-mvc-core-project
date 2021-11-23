using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models.Fees
{
    public class FeeRepository : IFeeRepository
    {
        private readonly StudentDBContext context;


        public FeeRepository(StudentDBContext context)
        {
            this.context = context;
        }
        public Fee Add(Fee register)
        {
            context.Fees.Add(register);
            context.SaveChanges();
            return register;
        }

        public Fee Delete(int id)
        {
            Fee fee = context.Fees.Find(id);

            if (fee != null)
            {
                context.Fees.Remove(fee);
                context.SaveChanges();
            }
            return fee;
        }

        public IEnumerable<Fee> GetAllRegister()
        {
           return context.Fees;
        }

        public IEnumerable<FeeBalance> Student_Fee()
        {
            var result = (from s in context.students
                          join f in context.Fees
                          on s.studentId equals f.StudentId
                          where f.Balance > 0
                          select new FeeBalance
                          {
                              Id = s.studentId,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              AmountPaid = f.AmountPaid,
                              DatePaid = f.Date_Paid,
                              Balance = f.Balance,
                              

                          }).ToList();
            return result;

        }
                
        public Fee GetRegister(int id)
        {
            return context.Fees.Find(id);
        }

        public Fee Update(Fee registerChanges)
        {
            var Fees = context.Fees.Attach(registerChanges);
            Fees.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return registerChanges;
        }
    }
}
