using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models.Fees
{
    public class Fee
    {
        public int FeeId { get; set; }

        [Required]
        [Display(Name="Amount Paid")]
        public int AmountPaid { get; set; }

        [Required]
        [Display(Name = "Date Paid")]
        public DateTime Date_Paid { get; set; }

        public int Balance { get; set; }


        public int? StudentId { get; set; }
        public student student { get; set; }

    }
}
