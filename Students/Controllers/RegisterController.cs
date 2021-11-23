using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Controllers
{
    [Authorize]
    public class RegisterController : Controller
    {
        private readonly IStudentsRepository _context;

        public RegisterController(IStudentsRepository context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult _student()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(student register)
        {
            if (ModelState.IsValid)
            {
                 _context.Add(register);

                return RedirectToAction("GetStudents");
                //return Ok("Added Successfully");
            }
            
            return PartialView("_student");
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
          var data = _context.GetAllRegister(); 
            
            return View(data);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
           var data = _context.GetRegister(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(student registerChanges)
        {
            var data = _context.Update(registerChanges);
            return RedirectToAction("GetStudents");
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult Delete_Get(int id)
        {
            var data = _context.GetRegister(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _context.Delete(id);
            return RedirectToAction("GetStudents");
        }

        [HttpGet]
        public IActionResult Student_Fee()
        {
            var data = _context.GetAllRegister();

            return View(data);
        }


    }
}
