using ForumApi.DAL;
using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // GET: api/<PostsController>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _postRepository.Select();
        }

        [HttpGet("{SubjectTitle}")]
        public IEnumerable<Post> SelectBySubjectTitle(string SubjectTitle)
        {
            return _postRepository.SelectBySubjectTitle(SubjectTitle);
        }

        //GET api/<PostsController>/5
        [HttpGet("curpost/{id}")]
        public Post GetbyId(string id)
        {
            return _postRepository.GetById(id);
        }

        // POST api/<PostsController>
        [HttpPost]
        public void Post([FromBody] Post model)
        {
            //Post user = JsonSerializer.Deserialize<Post>(model);
            _postRepository.Create(model);
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
