using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mosesbox_fit.Models;
using Mosesbox_fit.Services;

namespace Mosesbox_fit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly UsersService _usersService;
        Result result = new Result();

        public UsersController(UsersService service)
        {
            _usersService = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetAll()
        {
            try
            {
                var get_users = await _usersService.GetAllAsync();
                return Ok(get_users);
            }
            catch (Exception ex)
            {
                result.Message = "Error to get users";
                result.Status = 404;
                result.Error = ex;
                return BadRequest(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Users users)
        {
            try
            {
                await _usersService.CreateAsync(users);
            }
            catch (Exception ex)
            {
                result.Message = "Error create new user";
                result.Status = 404;
                result.Error = ex;
                return BadRequest(result);
            }
            return Ok(users);
        }
    }
}