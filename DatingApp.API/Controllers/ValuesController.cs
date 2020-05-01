using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    //http:localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;

        }
        //sync method
        /*
        [HttpGet]
        public IActionResult Get() //IActionResult return HttpResponse --200 to the client OkResult
        {
            // throw new System.Exception("Test exception");
            var values=_context.Values.ToList();
            return Ok(values);

        }
         [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var val=_context.Values.FirstOrDefault(x =>x.Id==id);
            return Ok(val);
        }
*/
//async comes with task
    [HttpGet]
        public async Task<IActionResult> Get() //IActionResult return HttpResponse --200 to the client OkResult
        {
            // throw new System.Exception("Test exception");
            var values= await _context.Values.ToListAsync();
            return Ok(values);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var val= await _context.Values.FirstOrDefaultAsync(x =>x.Id==id);
            return Ok(val);
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        [HttpPut("{id}")]
        public void Put(int id)
        {

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}