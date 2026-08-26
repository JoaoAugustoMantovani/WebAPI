using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Repository;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserDTO request)
        {
            var user = await _userService.CreateUser(request);
            
            if (user == null)
            {
                return BadRequest("Usuário não pode ser nulo");
            }
            
            return Ok(user);
        }

    }
}