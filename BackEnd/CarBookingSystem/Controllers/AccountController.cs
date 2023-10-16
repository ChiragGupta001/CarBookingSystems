using BusinessAccessLayer.Services;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices _account;
        public AccountController(IAccountServices account) 
        {
            _account = account;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(UserLoginDto user)
        {
            var response = await _account.IsLogin(user);
            if (response == null)
            {
                return NotFound("User don't Exist");
            }
            return Ok(response);
        }

        [HttpPost("SignUp")]
        public async Task<ActionResult> SignUp([FromForm]UserSignUpDto user)
        {
            var result = await _account.SignUp(user);
            return Ok(result);
        }

    }
}
