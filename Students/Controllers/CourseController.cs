using Microsoft.AspNetCore.Mvc;
using Students.Models;
using Students.Models.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICoursesRepository _context;
        public CourseController(ICoursesRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult _Course()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            Course1 c = new Course1();
            
            return PartialView("_Course", c);
        }


        [HttpPost]
        public IActionResult AddNew(Course1 register)
        {
                      
                if (ModelState.IsValid)
                {
                    _context.Add(register);

                    return RedirectToAction("GetCourses");
                }

                //return PartialView("_Course", register);
               return Ok("saved successfully");
            
        }

        [HttpGet]
        public IActionResult GetCourses()
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
        public IActionResult Edit(Course1 registerChanges)
        {
            var data = _context.Update(registerChanges);
            return RedirectToAction("GetCourses");
        }
    }
}
