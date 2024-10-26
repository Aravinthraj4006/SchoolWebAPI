using CrudProjectApi.DB;
using CrudProjectApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public TeacherController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("Create")]

        public IActionResult Create([FromBody]Teachers t)
        {
            _db.Teachers.Add(t);
            _db.SaveChanges();
            return Ok(t);
        }

        [HttpGet]
        [Route("GetAllDetails")]
        public IActionResult GetAllDetails()
        {
            List<Teachers>t=new List<Teachers>();
            t = _db.Teachers.ToList();
            return Ok(t);
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetDetailsById(int id)
        {
            Teachers t=_db.Teachers.FirstOrDefault(x=>x.Id == id);
           return Ok(t);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody]Teachers t)
        {
            _db.Update(t);
            _db.SaveChanges();
            return Ok(t);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            Teachers t=_db.Teachers.FirstOrDefault(x=> x.Id == id);
            _db.Remove(t);
            _db.SaveChanges();
            return Ok(t);
        }

    }
}
