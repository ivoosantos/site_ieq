using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.LoginUser;

namespace SiteCRM.API.Controllers
{
	[Route("api/users")]
	[Authorize]
	public class UsersController : ControllerBase
	{
		private readonly IMediator _mediator;

		// api/users/login
		[HttpPut("login")]
		[AllowAnonymous]
		public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
		{
			var loginUserviewModel = await _mediator.Send(command);

			if (loginUserviewModel == null)
			{
				return BadRequest();
			}

			return Ok(loginUserviewModel);
		}
	}
}
