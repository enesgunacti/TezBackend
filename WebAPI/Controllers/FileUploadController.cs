using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private static IWebHostEnvironment _webHostEnvironment;
        public FileUploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<string> Upload([FromForm]UploadFile obj)
        {
            if (obj.Files.Length>0)
            {
                try
                {
                    if (!Directory.Exists(_webHostEnvironment.WebRootPath+"\\Images\\"))
                    {
                        Directory.CreateDirectory(_webHostEnvironment.WebRootPath+ "\\Images\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_webHostEnvironment.WebRootPath+ "\\Images\\" + obj.Files.FileName))
                    {
                        obj.Files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Images\\" + obj.Files.FileName;
                    }
                }
                catch (Exception ex )
                {
                    return ex.ToString();
                    
                }
            }
            else
            {
                return "Upload Failed";
            }
            
        }
    }
}
