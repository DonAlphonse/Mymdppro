using Microsoft.AspNetCore.Mvc;
using Mymdpapp.Infrastructure;
using Mymdpapp.Applicat;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mymdpapp.APIWeb.Controllers
{
    [Route("api/Websites")]
    [ApiController]
    public class WebsitesController : ControllerBase
    {
        public WebsitesController() { }

        Application monApp = new Application();

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Websity> Get()
        {
            return new List<Websity> { new Websity() };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        //public void Post([FromBody] string value)
        public void Post([FromBody] Websity websity)
        {
            //Call of SaveToDatabase method from Application project
            monApp.SaveToDatabase(websity);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
