using communitybuilderapi.DataModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace communitybuilderapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadWebCamVideoController : ApiController
    {
        private IWebHostEnvironment _IWebHostEnvironment;
        public UploadWebCamVideoController(IWebHostEnvironment IWebHostEnvironment)
        {
            _IWebHostEnvironment = IWebHostEnvironment;
        }
        [HttpPost]
        [Route("UploadVideo")]
        public async Task<string> SaveVideo()
        {
            try
            {
                string path = string.Empty;
                video video = new video();
                var blob = HttpContext.Request.Form.Files;
               

                if (HttpContext.Request.Form.Files.Any())
                {
                    foreach (var file in HttpContext.Request.Form.Files)
                    {
                        path = Path.Combine(_IWebHostEnvironment.ContentRootPath, "Upload/video", DateTime.Now + "_" + file.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        video.name = Path.GetFileName(file.FileName);
                        //video.FileExtension = System.IO.Path.GetExtension(file.FileName);
                        video.type = file.ContentType;
                        float size = file.Length;
                        video.size = Convert.ToString(size / 1024);
                    }
                }
                return path;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
