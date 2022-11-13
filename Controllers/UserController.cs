using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCSA.Data;
using TCSA.Models;

namespace TCSA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{email}")]
        public async Task<AppUser> GetUser(string email)
        {
            var user = await _context.Users
                .Include(x => x.DashboardProjects)
                .SingleAsync(x => x.Email == email);

            return user;
        }

        [HttpPost]
        public async Task<IActionResult> PostProject(DashboardProject project)
        {
            if (project.GithubUrl== null)
            {
                project.GithubUrl = "Project is article";
            }
            await _context.DashboardProjects.AddAsync(project);
            var response = await _context.SaveChangesAsync();   
            return Ok(response);
        }
    }
}
