using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepliesController : ControllerBase
    {
        private readonly IReplyRepository _replyRepository;

        public RepliesController(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        // GET: api/<ValuesController>
        [HttpGet("{PostId}")]
        public IEnumerable<Reply> SelectByPostId(string PostId)
        {
            return _replyRepository.SelectByPostId(PostId);
        }

        // GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Reply value)
        {
            _replyRepository.Create(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
        }
    }
}
