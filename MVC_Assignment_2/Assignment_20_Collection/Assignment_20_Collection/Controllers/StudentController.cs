using Assignment_20_Collection.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Formats.Asn1.AsnWriter;
using System.Net;
using System.Xml.Linq;

namespace Assignment_20_Collection.Controllers
{
    public class StudentController : Controller
    {

        List<Student> list;
        public StudentController()
        {
            if (list == null)
            {
                list = new List<Student>()
                {
                new Student()
                {
                    Id = 1,
                    Name = "Jaya",
                    Address = "Goa",
                    Score = 50
                },
                new Student()
                {
                    Id = 2,
                    Name = "Sushma",
                    Address = "Delhi",
                    Score = 50
                },
                new Student()
                {
                    Id = 3,
                    Name = "Rekha",
                    Address = "Maharashtra",
                    Score = 50
                },
                new Student()
                {
                    Id = 4,
                    Name = "Hema",
                    Address = "Kerla",
                    Score = 50
                }
                };
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Display()
        { 
            Student student = new Student()
            {
                Id = 1,
                Name = "Jaya",
                Address = "Goa",
                Score = 50
            };
            ViewBag.student = student;
            return View();

        }
        public IActionResult List() {
            List<Student> list;
            list = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Jaya",
                    Address = "Goa",
                    Score = 50
                },
                new Student()
                {
                    Id = 2,
                    Name = "Sushma",
                    Address = "Delhi",
                    Score = 50
                },
                new Student()
                {
                    Id = 3,
                    Name = "Rekha",
                    Address = "Maharashtra",
                    Score = 50
                },
                new Student()
                {
                    Id = 4,
                    Name = "Hema",
                    Address = "Kerla",
                    Score = 50
                }

            };
            ViewBag.list = list;
            return View();
        }

        //Strongly type view
        public IActionResult Show()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Jaya",
                Address = "Goa",
                Score = 50
            };

            return View(student);

        }

        public IActionResult List1() {
            List<Student> list;
            list = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Jaya",
                    Address = "Goa",
                    Score = 50
                },
                new Student()
                {
                    Id = 2,
                    Name = "Sushma",
                    Address = "Delhi",
                    Score = 50
                },
                new Student()
                {
                    Id = 3,
                    Name = "Rekha",
                    Address = "Maharashtra",
                    Score = 50
                },
                new Student()
                {
                    Id = 4,
                    Name = "Hema",
                    Address = "Kerla",
                    Score = 50
                }

            };
            return View(list);
        }
    }
}
