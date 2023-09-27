using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    //    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }


        [HttpGet] // este se llama así   [Route("api/users")]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            // return _context.Users.ToList();
            var users = await _context.Users.ToListAsync();
            return users;
        }

        // https://localhost:5001/api/user/2
        [HttpGet("{id}")]

        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return  await _context.Users.FindAsync(id);
        }

    }
}