using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class RegistrationController : ControllerBase
{
   private MyContext _context = new MyContext();

   [HttpGet]
   public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetUsers(){
    var users = await _context.Users.ToListAsync();
    return Ok(users);
   }

}