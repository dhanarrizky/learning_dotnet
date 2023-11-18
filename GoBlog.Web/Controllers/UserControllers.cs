using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoBlog.Web
{
    [Route("Users")]
    public class UserControllers : Controller
    {
        private readonly ILogger<UserControllers> _logger;
        private readonly UsersService _service;

        public UserControllers(ILogger<UserControllers> logger,UsersService service)
        {
            _logger = logger;
            _service = service;
        }

        // GET: UserControllers
        [HttpGet("Index")]
        public ActionResult Index()
        {
            var users = _service.GetAll();
            return View("Views/Users/Index.cshtml",users); // => go to users
            // return View(users);  // => go to shared
        }

        [HttpGet("Detail/{id}")]
        public ActionResult Detail(ulong id)
        {
            var user = _service.GetById(id);
            return View("Views/Users/Index.cshtml",user);
        }

        [HttpGet("Create")]
        public ActionResult Create()
        {
            return View("Views/Users/Upsert.cshtml");
        }

        [HttpPost("Create")]
        public ActionResult Create(UserModel user)
        {
            var response = _service.Create(user);
            return RedirectToAction("Views/Users/Index.cshtml");
        }

        [HttpGet("Update/{id}")]
        public ActionResult Update(ulong id)
        {
            var user = _service.GetById(id);
            return View("Views/Users/Index.cshtml",user);
        }

        [HttpPut("Update")]
        public ActionResult Update(UserModel user)
        {
            var response = _service.Update(user);
            return RedirectToAction("Views/Users/Index.cshtml");
        }

        [HttpDelete("Delete/{id}")]
        public ActionResult Delete(ulong id)
        {
            var response = _service.Delete(id);
            return RedirectToAction("Views/Users/Index.cshtml",response);
        }

    }
}
