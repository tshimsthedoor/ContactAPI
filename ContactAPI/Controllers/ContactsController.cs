using Microsoft.AspNetCore.Mvc;

namespace ContactAPI.Controllers
{

    [ApiController]
    [Route("api/[controller")]
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
