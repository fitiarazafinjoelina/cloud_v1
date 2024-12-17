using cloud.Database;
using cloud.Model;
using Microsoft.AspNetCore.Mvc;

namespace cloud.Api;

[ApiController]
[Route("/api/[controller]/[action]")]

public class UserController: ControllerBase {
    private readonly AppDbContext _context;

    public UserController(AppDbContext context) {
        _context = context;
    }


    [HttpGet]
    public IActionResult Users() {
        // List<string> list = new List<string>();
        // list.Add("hello");
        return Ok(_context.Users.ToList());
    }
}