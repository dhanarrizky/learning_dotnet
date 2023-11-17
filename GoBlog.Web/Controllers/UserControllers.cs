using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("Users")]
    public class UserControllers : Controller
    {
        private ILogger<UserControllers> _logger;
        private UsersService _service;

        public UserControllers(ILogger<UserControllers> logger,UsersService service)
        {
            _logger = logger,
            _service = service
        }

        // GET: UserControllers
        public ActionResult Index()
        {
            var users = ser
            return View();
        }

    }
}
