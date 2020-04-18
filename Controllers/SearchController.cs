using System;
using Microsoft.AspNetCore.Mvc;

namespace generatorID.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string student_id)
        {
            if (Database.shared?.students != null)
                foreach (var student in Database.shared.students)
                {
                    string gennerator_id = "";
                    gennerator_id = Convert.ToString(student.FullName[0]);
                    string per = Convert.ToString(student.FullName[student.FullName.Length - 1]).ToUpper();
                    gennerator_id += per;
                    gennerator_id += Convert.ToString(student.FullName.Length);
                    gennerator_id += student.DOB[student.DOB.Length - 2];
                    gennerator_id += student.DOB[student.DOB.Length - 1];
                    gennerator_id += student.Group[student.Group.Length - 4];
                    gennerator_id += student.Group[student.Group.Length - 2];
                    if (gennerator_id.Equals(student_id))
                    {
                        return Content("name: " + student.FullName + "\nbirth of day: " + student.DOB + "\ngroup: " + student.Group);
                    }
                }
            return Content("not found");
        }
    }
}