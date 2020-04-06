using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadEG.Models
{
    public class ProfilePicture
    {
        public IFormFile ProfileUpload { get; set; }
    }
}
