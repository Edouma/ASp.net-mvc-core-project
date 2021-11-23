using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Students.Models;
using Students.Models.Fees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Controllers
{
    public class FeeController : Controller
    {
        private readonly IFeeRepository _context;

        public FeeController(IFeeRepository context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(Fee register)
        {
            if (ModelState.IsValid)
            {
                _context.Add(register);

                return RedirectToAction("GetFees");
            }

            return PartialView("_Fee");
        }

        [HttpGet]
        public IActionResult GetFees()
        {
            var data = _context.GetAllRegister();

            return View(data);
        }

        [HttpGet]
        public IActionResult Student_Fee()
        {
                       
            var data = _context.Student_Fee().ToList();
            
            return Ok(data);
        }

        [HttpGet]
        public IActionResult Student_Fee1()
        {
           

            return View();
        }




    }
}
