using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // Source of all entities mapped over a database connection
        // Tracks changes that you made to all retrieved entities
        // Gives access to the database
        private readonly DataContext _context;

        public UsersController(DataContext context) {
            _context = context;
        }

        // Endpoints

        //Get all users
        [HttpGet]
        public async  Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            return await _context.Users.ToListAsync();
        }

        //Get single user
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUserAsync(int id){
            return await _context.Users.FindAsync(id);
        }
        
    }
}