﻿using ForumApi.Domain.Entities;
using ForumApi.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IFileUploadService _fileUploadService;

        public UploadFileController(IFileUploadService fileUploadService)
        {
            _fileUploadService = fileUploadService;
        }

        [HttpPost("UploadFile")]
        public async Task UploadFileAsync(IFormFile file)
        {
            try
            {
                if (await _fileUploadService.UploadFileAsync(file))
                {
                    Ok("File upload successful");
                }
                else
                {
                    BadRequest("File upload failed");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("File upload failed", ex);
            }
        }

        [HttpPost("UploadFiles")]
        public async Task UploadFilesAsync(IFormFileCollection files)
        {
            try
            {
                if (await _fileUploadService.UploadFilesAsync(files))
                {
                    Ok("Files upload successful");
                }
                else
                {
                    BadRequest("Files upload failed");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Files upload failed", ex);
            }
        }  
    }
}
