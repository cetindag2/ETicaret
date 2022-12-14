using ETicaretAPI.Application.Features.Commands.AppUser.CreateUser;
using ETicaretAPI.Application.Features.Commands.AppUser.LoginUser;
using MediatR;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }
<<<<<<< HEAD
=======
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
        {
            LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest);
            return Ok(response);
        }
>>>>>>> c89537d5c716034eb4e934d3116ca06e5454494c
    }
}
