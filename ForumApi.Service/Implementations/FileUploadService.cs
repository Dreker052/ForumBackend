using ForumApi.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;

namespace ForumApi.Service.Implementations
{
    public class FileUploadService : IFileUploadService
    {
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IUploadedFileRepository _uploadedFileRepository;
        private readonly ICreateRandomNameService _createRandomNameService;

        public FileUploadService(IHostingEnvironment appEnvironment, IUploadedFileRepository uploadedFileRepository, ICreateRandomNameService createRandomNameService)
        {
            _appEnvironment = appEnvironment;
            _uploadedFileRepository = uploadedFileRepository;
            _createRandomNameService = createRandomNameService;
        }

        public async Task<bool> UploadFileAsync(IFormFile file, string postId)
        {
            try
            {
                if (file != null)
                {
                    string path = "/UploadedFiles/" + _createRandomNameService.CreateRandomName(24) + file.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    UploadedFile uploadedFile = new UploadedFile { PostId = postId, Path = path };
                    _uploadedFileRepository.Create(uploadedFile);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw new Exception("File copy failed", ex);
            }
        }

        public async Task<bool> UploadFilesAsync(IFormFileCollection files, string postId)
        {
            try
            {
                if(files != null)
                {
                    foreach (var file in files)
                    {
                        string path = "/UploadedFiles/" + _createRandomNameService.CreateRandomName(24) + file.FileName;
                        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }
                        UploadedFile uploadedFile = new UploadedFile { PostId = postId, Path = path };
                        _uploadedFileRepository.Create(uploadedFile);
                    }

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("File copy failed", ex);
            }
        }
    }
}
