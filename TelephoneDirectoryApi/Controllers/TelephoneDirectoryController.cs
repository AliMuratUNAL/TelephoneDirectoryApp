using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelephoneDirectoryApi.Entities;

namespace TelephoneDirectoryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TelephoneDirectoryController : ControllerBase
    {
        private readonly ILogger<TelephoneDirectoryController> _logger;

        private readonly PgContext _context;
        public TelephoneDirectoryController(ILogger<TelephoneDirectoryController> logger, PgContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetTelephoneDirectorys")]
        public async Task<IActionResult> GetTelephoneDirectorys()
        {
            var asyncTelephoneDirectorys = await _context.TelephoneDirectorys.ToListAsync();
            //_logger.LogInformation("Log Information");
            return Ok(asyncTelephoneDirectorys);
        }

        [HttpGet("{id}")]
        public IActionResult GetTelephoneDirectoryById(Guid id)
        {
            return Ok(_context.TelephoneDirectorys.FirstOrDefault(p => p.ID == id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTelephoneDirectory(Guid id, TelephoneDirectory telephoneDirectory)
        {
            var updateProduct = _context.TelephoneDirectorys.FirstOrDefault(p => p.ID == id);
            updateProduct.Name = telephoneDirectory.Name;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTelephoneDirectory(Guid id)
        {
            var deletedProduct = _context.TelephoneDirectorys.FirstOrDefault(p => p.ID == id);
            _context.Remove(deletedProduct);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public IActionResult AddTelephoneDirectory(TelephoneDirectory telephoneDirectory)
        {
            _context.Add(telephoneDirectory);
            _context.SaveChanges();
            return Created("", telephoneDirectory);
        }
    }
}