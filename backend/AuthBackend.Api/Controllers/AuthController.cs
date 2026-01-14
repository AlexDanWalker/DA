using Microsoft.AspNetCore.Mvc;
using AuthBackend.Application.Services;
using AuthBackend.Application.Dtos;

namespace AuthBackend.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] AuthRequestDto dto)
        {
            var user = _authService.Register(dto.Name, dto.Email);
            if (user == null)
                return BadRequest("Usuario ya existe");
            return Ok(user);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] AuthRequestDto dto)
        {
            var user = _authService.Login(dto.Name, dto.Email);
            if (user == null)
                return Unauthorized("Credenciales incorrectas");
            return Ok(user);
        }
    }
}