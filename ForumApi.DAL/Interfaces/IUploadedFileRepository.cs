using ForumApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.DAL.Interfaces
{
    public interface IUploadedFileRepository:IBaseRepository<UploadedFile>
    {
        public IEnumerable<UploadedFile> SelectByPostId(string postId);
    }
}
