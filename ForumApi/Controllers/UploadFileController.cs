using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;
using ForumApi.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IFileUploadService _fileUploadService;
        private readonly IUploadedFileRepository _uploadedFileRepository;

        public UploadFileController(IFileUploadService fileUploadService, IUploadedFileRepository uploadedFileRepository)
        {
            _fileUploadService = fileUploadService;
            _uploadedFileRepository = uploadedFileRepository;
        }

        [HttpPost("UploadFile")]
        public async Task UploadFileAsync(IFormFile file, string postId)
        {
            try
            {
                if (await _fileUploadService.UploadFileAsync(file, postId))
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
        public async Task UploadFilesAsync(IFormFileCollection files, string postId)
        {
            try
            {
                if (await _fileUploadService.UploadFilesAsync(files, postId))
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

        [HttpGet("{PostId}")]
        public IEnumerable<UploadedFile> SelectByPostId(string postId)
        {
            return _uploadedFileRepository.SelectByPostId(postId);
        }

        [HttpGet]
        public IEnumerable<UploadedFile> Select()
        {
            return _uploadedFileRepository.Select();
        }
    }
}
