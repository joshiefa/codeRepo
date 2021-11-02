using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController()
        {
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> postCustomer(Customer customer)
        {
            return BadRequest();
        }

    }
}
