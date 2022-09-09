using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.DAL.Repositories
{
    public class ReplyRepository : IReplyRepository
    {
        private readonly ApplicationDbContext _db;
        public ReplyRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create(Reply entity)
        {
            _db.Replies.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Reply Edit(string id, Reply entity)
        {
            throw new NotImplementedException();
        }

        public Reply Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reply> Select()
        {
            return _db.Replies.ToList();
        }

        public IEnumerable<Reply> SelectByPostId(string PostId)
        {
            return _db.Replies.Where(x => x.PostId == PostId);
        }
    }
}
