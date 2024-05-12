using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.CreateUser;
using SiteCRM.Application.Commands.LoginUser;
using SiteCRM.Application.Queries.GetUser;

namespace SiteCRM.API.Controllers
{
	[Route("api/users")]
	[Authorize]
	public class UsersController : ControllerBase
	{
		private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

		[HttpGet("{id}")]
		[AllowAnonymous]
		[ActionName(nameof(GetByIdAsync))]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			var query = new GetUserQuery(id);

			var user = await _mediator.Send(query);

			if(user == null)
				NotFound();

			return Ok(user);
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Post([FromBody]CreateUserCommand command)
		{
			var id = await _mediator.Send(command);

			return CreatedAtAction(nameof(GetByIdAsync), new {id = id}, command);
		}

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

        //TODO - Implementar Alteração
        //TODO - Implementar Delete
        //TODO - Implementar GetAll
    }
}
