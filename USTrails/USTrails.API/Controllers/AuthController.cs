using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using USTrails.API.Models.DTO;
using USTrails.API.Repositories;

namespace USTrails.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Create([FromBody] CreateUserRequestDto createUserRequestDto)
        {
            var newUser = new IdentityUser
            {
                UserName = createUserRequestDto.Username,
                Email = createUserRequestDto.Username
            };

            var user = await userManager.CreateAsync(newUser, createUserRequestDto.Password);
            if (user.Succeeded)
            {
                // Add roles to user
                if (createUserRequestDto.Roles != null && createUserRequestDto.Roles.Any())
                {
                    user = await userManager.AddToRolesAsync(newUser, createUserRequestDto.Roles);
                    if (user.Succeeded)
                    {
                        return Ok("User was registered successfully.");
                    }
                }
            }

            return BadRequest($"Something went wrong while registering the user. {user.Errors.First().Description}");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDto.Username);
            if (user != null)
            {
                if (await userManager.CheckPasswordAsync(user, loginRequestDto.Password))
                {
                    var roles = await userManager.GetRolesAsync(user);
                    if (roles != null)
                    {
                        var jwt = tokenRepository.CreateJWT(user, roles.ToList());
                        var response = new LoginResponseDto
                        {
                            Jwt = jwt
                        };

                        return Ok(response);
                    }

                    return BadRequest("User has no roles.");
                }
            }

            return BadRequest("Incorrect username or password.");
        }
    }
}
