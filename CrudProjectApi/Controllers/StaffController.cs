using CrudProjectApi.DB;
using CrudProjectApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public StaffController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpPost]
        [Route("Create")]

        public IActionResult Create([FromBody]Staff s1)
        {
            _db.Staffs.Add(s1);
            _db.SaveChanges();
            return Ok(s1);
           
        }


        [HttpGet]
        [Route("GetAllStaff")]
        public IActionResult Get()
        {
            List<Staff>staff=new List<Staff>();
            staff=_db.Staffs.ToList();
            return Ok(staff);
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult Get(int id)
        {
            Staff s1=_db.Staffs.FirstOrDefault(x=>x.Id==id);
            
            return Ok(s1);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody]Staff s)
        {
            _db.Update(s);
            _db.SaveChanges();
            return Ok(s);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            Staff s= _db.Staffs.FirstOrDefault(x=>x.Id==id);
            _db.Remove(s);
            _db.SaveChanges();
            return Ok(s);   
        }
    }
}
