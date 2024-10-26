using CrudProjectApi.DB;
using CrudProjectApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)//Create and Update [FromBody]Pass
        {
            _db = db;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody]Student s1)
        {
            _db.Students.Add(s1);
            _db.SaveChanges();
            return Ok(s1);
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAll()
        {
            List<Student>students=new List<Student>();
            students=_db.Students.ToList();
           return Ok(students);
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            Student s1 = _db.Students.FirstOrDefault(x => x.Id == id);
            return Ok(s1);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody]Student s1)
        {
           _db.Update(s1);
            _db.SaveChanges();
            return Ok(s1);
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteById(int id)
        {
            Student s1=_db.Students.FirstOrDefault(x=>x.Id == id);
            _db.Students.Remove(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
    }
}
