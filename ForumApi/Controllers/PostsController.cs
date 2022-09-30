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

        [HttpGet("curpost/{id}")]
        public Post GetbyId(string id)
        {
            return _postRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Post model)
        {
            _postRepository.Create(model);
        }  
    }
}
