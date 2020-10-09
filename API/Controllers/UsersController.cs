using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        public ActionResult<IEnumerable<AppUser>> GetUsers(){
            return _context.Users.ToList();
        }

        //Get single user
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id){
            return _context.Users.Find(id);
        }
        
    }
}