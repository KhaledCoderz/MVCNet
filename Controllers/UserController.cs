using Microsoft.AspNetCore.Mvc;
using MVCNet.Data;
using MVCNet.Models.Entity.User;

namespace MVCNet.Controllers
{
    public class UserController : Controller
    {

        private readonly MVCNetContext _context;

        public UserController(MVCNetContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<User> users = _context.User.ToList();
            return View(users);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User Model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.User.Add(Model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("General", "Something Went Very wrong");
                return View(Model);
            }
        }
    }
}
