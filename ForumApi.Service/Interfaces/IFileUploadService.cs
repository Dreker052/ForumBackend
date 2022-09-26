using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Service.Interfaces
{
    public interface IFileUploadService
    {
        public Task<bool> UploadFileAsync(IFormFile file, string postId);

        public Task<bool> UploadFilesAsync(IFormFileCollection files, string postId);
    }
}
