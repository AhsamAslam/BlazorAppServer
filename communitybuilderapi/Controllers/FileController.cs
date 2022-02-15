using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using communitybuilderapi.Commands.Files.UplaodFile;
using communitybuilderapi.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace communitybuilderapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ApiController
    {
        private IWebHostEnvironment _IWebHostEnvironment;
        public FileController(IWebHostEnvironment IWebHostEnvironment)
        {
            _IWebHostEnvironment = IWebHostEnvironment;
        }
        // GET: api/<FileController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        [Route("GetFile")]
        public async Task<string> GetFiles()
        {
            try
            {
                var PathBuild = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Upload\\Files");
                List<string> files = new List<string>();
                DirectoryInfo DirInfo = new DirectoryInfo(PathBuild);
                foreach (FileInfo FileInfo in DirInfo.GetFiles())
                {
                    files.Add(FileInfo.Name);
                }

                return JsonConvert.SerializeObject(files);
            }
            catch (Exception)
            {

                throw;
            }

        }

        // POST api/<FileController>
        [HttpPost]
        [Route("UploadFile")]
        public async Task<FileDto> UploadFile(IFormFile file)
        {
            try
            {
                var FileDto = new FileDto();
                FileDto.FileOriginalName = System.IO.Path.GetFileName(file.FileName);
                FileDto.FileExtension = System.IO.Path.GetExtension(file.FileName);
                FileDto.FileType = file.ContentType;
                float size = file.Length;
                FileDto.FileSize = (size / 1024);

                List<string> files = new List<string>();
                for (char letter = 'A'; letter <= 'Z'; letter++)
                {

                    var PathBuild = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Businesses\\_" + letter);
                    if (!Directory.Exists(PathBuild))
                    {
                        if (files.Count == 2)
                        {
                            Directory.CreateDirectory(PathBuild);
                        }

                    }
                    files.Clear();
                    if (Directory.Exists(PathBuild))
                    {

                        DirectoryInfo DirInfo = new DirectoryInfo(PathBuild);
                        foreach (FileInfo FileInfo in DirInfo.GetFiles())
                        {
                            files.Add(FileInfo.Name);
                        }
                    }


                }
                for (char letter = 'A'; letter <= 'Z'; letter++)
                {

                    var FilePath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Businesses\\_"+letter);
                    if (Directory.Exists(FilePath))
                    {
                        DirectoryInfo DirInfo = new DirectoryInfo(FilePath);
                        foreach (FileInfo FileInfo in DirInfo.GetFiles())
                        {
                            files.Add(FileInfo.Name);
                        }
                        if (files.Count < 2)
                        {
                            var FileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Businesses\\_" + letter, file.FileName);
                            using (var stream = new FileStream(FileSavePath, FileMode.Create))
                            {
                                await file.CopyToAsync(stream);
                            }
                            FileDto.FilePath = "~/Upload/Businesses/_"+letter+"/"+file.FileName;
                        }
                    }

                   
                    files.Clear();
                }

                
                files.Clear();
                return await Mediator.Send(new UploadFileCommand() { FileParam = FileDto });

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // PUT api/<FileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
