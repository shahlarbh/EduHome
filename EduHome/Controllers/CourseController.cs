using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _courseCount;

        public CourseController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _courseCount = _dbContext.Courses.Count();
        }

        public IActionResult Index()
        {
            ViewBag.CourseCount = _courseCount;

            var courses = _dbContext.Courses.Take(3).ToList();

            var courseViewModel = new CourseViewModel
            {
                Courses = courses,
            };

            return View(courseViewModel);
        }

        public IActionResult LoadCourses(int skipCourse)
        {
            var courses = _dbContext.Courses.Skip(skipCourse).Take(3).ToList();

            return PartialView("_CoursePartial", courses);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var courses = _dbContext.Courses.Find(id);

            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }
    }
}
