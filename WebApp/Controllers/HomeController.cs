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
        public async Task<IActionResult> IndexCourse(string search)
        {
            List<CourseModel> listCourse = null;
            if (search != null)
            {
                listCourse = new List<CourseModel>();
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync("https://localhost:44379/api/CourseAPI/name/" + search))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        listCourse = JsonConvert.DeserializeObject<List<CourseModel>>(apiResponse);
                    }
                }
            }
            else
            {
                listCourse = new List<CourseModel>();
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync("https://localhost:44379/api/CourseAPI"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        listCourse = JsonConvert.DeserializeObject<List<CourseModel>>(apiResponse);
                    }
                }
            }
            if(listCourse == null)
            {
                return NotFound();
            }
            return View(listCourse);
        }

        public async Task<IActionResult> DetailCourse(int id)
        {
            List<LessonModel> listLessonModel = new List<LessonModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:44379/api/LessonAPI/" + id))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return NotFound();
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listLessonModel = JsonConvert.DeserializeObject<List<LessonModel>>(apiResponse);
                }
            }
            int idLesson = listLessonModel.First().Id;
            List<CommemtLessonModel> listCommentLesson = new List<CommemtLessonModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:44379/api/CommemtLessonAPI/" + idLesson))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return NotFound();
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listCommentLesson = JsonConvert.DeserializeObject<List<CommemtLessonModel>>(apiResponse);
                }
            }
            if (listLessonModel == null)
            {
                return NotFound();
            }
            ViewBag.ListCom = listCommentLesson;
            return View(listLessonModel);
        }


        public async Task<IActionResult> DetailLesson(int? id)
        {
            LessonModel lessonModel = new LessonModel();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:44379/api/LessonAPIModels/" + id))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return NotFound();
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    lessonModel = JsonConvert.DeserializeObject<LessonModel>(apiResponse);
                }
            }
            List<LessonModel> listLessonModel = new List<LessonModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:44379/api/LessonAPI/" + lessonModel.IdCourse))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return NotFound();
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listLessonModel = JsonConvert.DeserializeObject<List<LessonModel>>(apiResponse);
                }
            }
            
            List<CommemtLessonModel> listCommentLesson = new List<CommemtLessonModel>();
            using (var client = new HttpClient())
            {
                //Sua cho nay thanh id
                using (var response = await client.GetAsync("https://localhost:44379/api/CommemtLessonAPI/" + id))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        return NotFound();
                    }
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    listCommentLesson = JsonConvert.DeserializeObject<List<CommemtLessonModel>>(apiResponse);
                }
            }
            if (lessonModel == null)
            {
                return NotFound();
            }
            ViewBag.ListLesson = listLessonModel;
            ViewBag.ListComment = listCommentLesson;
            ViewData["IdLesson"] = id;
            return View(lessonModel);
        }

        public IActionResult IndexPost()
        {
            return View();
        }
        public IActionResult DetailPost()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult chat()
        {
            return View();
        }
    }
}
