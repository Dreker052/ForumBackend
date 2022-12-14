using ForumApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.DAL.Interfaces
{
    public interface IPostRepository:IBaseRepository<Post>
    {
        public IEnumerable<Post> SelectBySubjectTitle(string SobjectTitle);

        public Post GetById(string id);
    }

    
}
