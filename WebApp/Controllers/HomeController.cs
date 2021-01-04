using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApp.Areas.Admin.Data;
using WebApp.Areas.Admin.Models;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> IndexCourse()
        {
            List<CourseModel> listCourse = new List<CourseModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:44379/api/CourseAPI"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listCourse = JsonConvert.DeserializeObject<List<CourseModel>>(apiResponse);
                }
            }
            if(listCourse == null)
            {
                return NotFound();
            }
            return View(listCourse);
        }
        public async Task<IActionResult> DetailLesson(int id)
        {
            CourseModel courseModel = new CourseModel();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:44379/api/CourseAPI/"+id))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return NotFound();
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    courseModel = JsonConvert.DeserializeObject<CourseModel>(apiResponse);
                }
            }
            if (courseModel == null)
            {
                return NotFound();
            }
            return View(await _context.Course.ToListAsync());
        }
        public async Task<IActionResult> DetailLesson(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var lessonModel = await _context.Lesson.FindAsync(id);
            if(lessonModel == null)
            {
                return NotFound();
            }
            return View(lessonModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
