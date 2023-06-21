using EduHome.DataAccessLayer;
using EduHome.DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Areas.AdminPanel.Controllers
{
    public class CourseController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public CourseController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _dbContext.Courses.ToListAsync();

            return View(courses);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var course = await _dbContext.Courses.FirstOrDefaultAsync(x => x.Id == id);

            if (course == null)
                return NotFound();

            return View(course);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var isExist = await _dbContext.Courses.AnyAsync(x => x.Title.ToLower().Equals(course.Title.ToLower()));

            if (isExist)
            {
                ModelState.AddModelError("Title", "Bu adda Course movcuddur");

                return View();
            }

            await _dbContext.Courses.AddAsync(course);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
