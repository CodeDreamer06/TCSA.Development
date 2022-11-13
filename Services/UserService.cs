using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCSA.Data;
using TCSA.Models;

namespace TCSA.Services;

public interface IUserService
{
    Task<AppUser> GetUser(string email);
    Task PostProject(DashboardProject project);
    Task MarkAsIncomplete(DashboardProject project);
}

public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AppUser> GetUser(string email)
    {
        var user = await _context.Users
            .Include(x => x.DashboardProjects)
            .SingleAsync(x => x.Email == email);

        return user;
    }

    [HttpPost]
    public async Task PostProject(DashboardProject project)
    {
        if (project.GithubUrl == null)
        {
            project.GithubUrl = "Project is article";
        }
        await _context.DashboardProjects.AddAsync(project);
        var response = await _context.SaveChangesAsync();
    }

    [HttpPost]
    public async Task MarkAsIncomplete(DashboardProject project)
    {
        project.IsCompleted = false;

        _context.DashboardProjects.Update(project);

        var response = await _context.SaveChangesAsync();
    }
}
