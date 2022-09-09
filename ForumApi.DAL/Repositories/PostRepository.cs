using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.DAL.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _db;
        public PostRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create(Post entity)
        {
            _db.Posts.Add(entity);
            _db.SaveChangesAsync();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Post Edit(string id, Post entity)
        {
            throw new NotImplementedException();
        }

        public Post Get(string id)
        {
            return _db.Posts.Find(id);
        }

        public Post GetById(string id)
        {
            return _db.Posts.Find(id);
        }

        public IEnumerable<Post> Select()
        {
           return _db.Posts.ToList();
        }

        public IEnumerable<Post> SelectBySubjectTitle(string SubjectTitle)
        {
            return _db.Posts.Where(x => x.SubjectTitle == SubjectTitle);
        }
    }
}
