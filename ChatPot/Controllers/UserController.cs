using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatPot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost()]
        public IActionResult GetReply(string Queistion)
        {
            string Reply = $"Yes, My Conrollers is Working With Your String Queistion  {Queistion}";
            return Ok(Reply);

        }
    }
}
