using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileUploadEG.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FileUploadEG.Controllers
{
    public class ProfilePictureExController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<ProfilePictureExController> _logger;
        public ProfilePictureExController(ILogger<ProfilePictureExController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UploadFile(ProfilePicture fileUpload)
        {
            string strpath = System.IO.Path.GetExtension(fileUpload.ProfileUpload.FileName);
            if (fileUpload.ProfileUpload != null && (strpath == ".jpg" && strpath == ".jpeg" && strpath == ".gif" && strpath == ".png"))
            { 
                { 
                    string FilePath = $"{_env.WebRootPath}/images/{fileUpload.ProfileUpload.FileName}";
                var stream = System.IO.File.Create(FilePath);
                fileUpload.ProfileUpload.CopyTo(stream);
                return Redirect("/ProfilePictureEx/Success");
            }
            }


            return Redirect("/");

        }
        public IActionResult Success()
        {
            return View();
        }

    }
}