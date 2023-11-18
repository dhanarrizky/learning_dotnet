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
            var users = _service.GetAllUsers();
            return View("Views/Users/Index.cshtml",users); // => go to users
            // return View(users);  // => go to shared
        }

        [HttpGet("Detail/{id}")]
        public ActionResult Detail(ulong id)
        {
            var user = _service.GetUserById(id);
            return Veiw("View/Users/Index.cshtml",);
        }

        [HttpPost("Detail")]
        public ActionResult Detail()
        {
            
        }

        [HttpGet("Update/{id}")]
        public ActionResult Update(ulong id)
        {
            var user = _service.GetUserById(id);
            return Veiw("View/Users/Index.cshtml",);
        }

        [HttpPut("Update")]
        public ActionResult Update()
        {
            
        }

        [HttpDelete("Delete/{id}")]
        public ActionResult Delete(ulong id)
        {
            var user = _service.GetUserById(id);
            return Veiw("View/Users/Index.cshtml",);
        }




    }
}
