using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TCSA.Data;
using TCSA.Models;

namespace TCSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UserController(UserManager<AppUser> userManager, ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string email)
        {
            var user = await _context.Users.SingleAsync(x => x.Email == email);

            return Ok(user);
        }
    }
}
