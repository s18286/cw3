using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public string GetStudent(string orderBy)
        {
            return $"Kowalski, Malewski, Andrzejewski, orderBy={orderBy}";
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            Console.WriteLine("post");
            student.indexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
    }
}