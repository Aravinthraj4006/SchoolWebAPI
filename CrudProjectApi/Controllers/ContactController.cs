using CrudProjectApi.DB;
using CrudProjectApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contact s1)
        {
            _context.Contact.Add(s1);
            _context.SaveChanges();
            return Ok(s1);
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            Contact s1 = _context.Contact.FirstOrDefault(x => x.Id == id);

            return Ok(s1);
        }

        [HttpGet("GetAllContact")]
        public IActionResult Get()
        {
            List<Contact>contacts =new List<Contact>();
            contacts = _context.Contact.ToList();
            return Ok(contacts);
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] Contact s)
        {
            _context.Update(s);
            _context.SaveChanges();
            return Ok(s);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            Contact s = _context.Contact.FirstOrDefault(x => x.Id == id);
            _context.Remove(s);
            _context.SaveChanges();
            return Ok(s);
        }
    }
}
