using Microsoft.AspNetCore.Http;
using System;
using XbShopSolution.Application.Services.IService;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace XbShopSolution.Application.Services.Service
{
    public class FileService : IFileService
    {
        private readonly string _userContentFolder;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";

        public FileService(IWebHostEnvironment environment)
        {
            _userContentFolder = Path.Combine(environment.WebRootPath, USER_CONTENT_FOLDER_NAME);
        }
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            try
            {
                if (!Directory.Exists(_userContentFolder))
                {
                    Directory.CreateDirectory(_userContentFolder);
                }
                var ext = Path.GetExtension(imageFile.FileName);
                var allowedExtensions = new string[] { ".jpg", ".png", ".jpeg" };
                if (!allowedExtensions.Contains(ext))
                {
                    string msg = string.Format("Only {0} extensions are allowed", string.Join(",", allowedExtensions));
                    return "not";
                }
                string uniqueString = Guid.NewGuid().ToString();
                var newFileName = uniqueString + ext;
                var fileWithPath = Path.Combine(_userContentFolder, newFileName);
                var stream = new FileStream(fileWithPath, FileMode.Create);
                imageFile.CopyTo(stream);
                stream.Close();
                return "ok";
            }
            catch(Exception ex)
            {
                return "not ";
            }
        }
    }
}