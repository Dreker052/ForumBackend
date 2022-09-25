﻿using ForumApi.Service.Interfaces;
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

        public FileUploadService(IHostingEnvironment appEnvironment, IUploadedFileRepository uploadedFileRepository)
        {
            _appEnvironment = appEnvironment;
            _uploadedFileRepository = uploadedFileRepository;
        }

        public async Task<bool> UploadFileAsync(IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    string path = "/UploadedFiles/" + file.FileName;
                    using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    UploadedFile uploadedFile = new UploadedFile { Name = file.Name, Path = path };
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

        
    }
}