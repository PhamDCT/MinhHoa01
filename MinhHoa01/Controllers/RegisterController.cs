using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhHoa01.Models;
using System.IO;
using System;
using Microsoft.AspNetCore.Hosting;

namespace MinhHoa01.Controllers
{
    public class RegisterController : Controller
    {
        private IHostingEnvironment hosting;

        public RegisterController(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult xuly(Person p, IFormFile FHinh)
        {
            if (FHinh != null)
            {
                //xuly 
                // string filename = FHinh.FileName;
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
                //string path = hosting.WebRootPath + "/img"; 
                string path = Path.Combine(hosting.WebRootPath + "/img");
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    //sao chep len server
                    FHinh.CopyTo(filestream);
                }
                p.Picture = filename;
            }
            return View(p);
        }

    }
}
