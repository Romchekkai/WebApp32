using Microsoft.AspNetCore.Mvc;
using WebApp32.Models.Db.Entities;
using WebApp32.Models.Db.Repositories;

namespace WebApp32.Controllers
{
    public class UsersController : Controller
    {
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {

            // Добавим в базу
            await _repo.AddUser(user);
            // Выведем результат
            return View(user);
        }
    }
}
