using BT1.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using BT1.ViewModel;

namespace BT1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(m=> m.Lecturer)
                .Include(m => m.Category)
                .Where( m => m.DateTime > DateTime.Now);

           
            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upcommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
        }
        
    }
}