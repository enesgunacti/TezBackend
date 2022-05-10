using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UploadService
    {
        private static IWebHostEnvironment _webHostEnvironment;
        public UploadService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<string> Upload([FromForm] UploadFile obj)
        {
            if (obj.Files.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_webHostEnvironment.WebRootPath + "\\Images\\"))
                    {
                        Directory.CreateDirectory(_webHostEnvironment.WebRootPath + "\\Images\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_webHostEnvironment.WebRootPath + "\\Images\\" + obj.Files.FileName))
                    {
                        obj.Files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Images\\" + obj.Files.FileName;
                    }
                }
                catch (Exception ex)
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
