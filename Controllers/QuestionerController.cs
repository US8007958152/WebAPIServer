using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAPIServer.Entities;

namespace WebAPIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionerController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public QuestionerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult GetQuestions()
        {
            try
            {
                string filePath = _configuration.GetSection("JsonDataSource").Value;
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string question = reader.ReadToEnd();
                    DataModel dataModel = JsonConvert.DeserializeObject<DataModel>(question);
                    return Ok(dataModel);
                }

            }
            catch(Exception ex)
            {
                return StatusCode(500,"Something went wrong");
            }
        }
    }
}
