using EduHome.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Areas.AdminPanel.Controllers
{
    public class TeacherController : AdminController
    {
        private readonly AppDbContext _dbContext;

        public TeacherController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var teachers = await _dbContext.Teachers.ToListAsync();

            return View(teachers);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
                return NotFound();

            var teacher = await _dbContext.Teachers.FirstOrDefaultAsync(x=>x.Id == id);

            if(teacher == null)
                return NotFound();

            return View(teacher);
        }
    }
}
