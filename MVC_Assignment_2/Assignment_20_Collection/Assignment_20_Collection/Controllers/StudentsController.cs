using Assignment_20_Collection.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_20_Collection.Controllers
{
    public class StudentsController : Controller
    {
        static List<Student> list;
        public StudentsController()
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
            return View(list);
        }

        public IActionResult Details(int id)
        {
            return View(list.FirstOrDefault(x => x.Id == id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            list.Add(student);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(list.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Student student)
        {
            foreach (var temp in list)
            {
                if (temp.Id == id)
                {
                    temp.Address = student.Address;
                    temp.Score = student.Score;

                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(list.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public IActionResult Delete(int id, Student student)
        {
            foreach (var temp in list)
            {
                if (temp.Id == id)
                {
                   list.Remove(temp);
                    break;

                }
            }
            return RedirectToAction("Index");
        }

    }
}
