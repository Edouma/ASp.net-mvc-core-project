using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class FeeBalance
    {
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public int AmountPaid { get; set; }
        public DateTime DatePaid { get; set; }
        public int Balance { get; set; }
    }
}
