using ForumApi.Domain.Entities;
using ForumApi.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IFileUploadService _fileUploadService;

        public UploadFileController(IFileUploadService fileUploadService)
        {
            _fileUploadService = fileUploadService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task Post(IFormFile file)
        {
            try
            {
                if (await _fileUploadService.UploadFileAsync(file))
                {
                    Ok("File upload successful");
                }
                else
                {
                    BadRequest("File Upload Failed");
                }
            }
            catch (Exception)
            {

                throw;
            }
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
