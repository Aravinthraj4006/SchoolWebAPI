using CrudProjectApi.DB;
using CrudProjectApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly ApplicationDbContext _db;


        public FeedbackController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpPost]
        [Route("Create")]

        public IActionResult Create([FromBody] Feedback s1)
        {
            _db.Feedback.Add(s1);
            _db.SaveChanges();
            return Ok(s1);

        }


        [HttpGet]
        [Route("GetAllFeedback")]
        public IActionResult Get()
        {
            List<Feedback> Feedback = new List<Feedback>();
            Feedback = _db.Feedback.ToList();
            return Ok(Feedback);
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult Get(int id)
        {
            Feedback s1 = _db.Feedback.FirstOrDefault(x => x.Id == id);

            return Ok(s1);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] Feedback s)
        {
            _db.Update(s);
            _db.SaveChanges();
            return Ok(s);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            Feedback s = _db.Feedback.FirstOrDefault(x => x.Id == id);
            _db.Remove(s);
            _db.SaveChanges();
            return Ok(s);
        }
    }
}
