using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Core.Entities;

namespace SiteCRM.API.Controllers
{
	[Route("api/missoes")]
	[ApiController]
	//[Authorize]
	public class MissoesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public MissoesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromForm]Missoes missoes)
		{
			var filePath = Path.Combine("Storage", missoes.img.FileName);
			using Stream fileStream = new FileStream(filePath, FileMode.Create);
			missoes.img.CopyTo(fileStream);
			
			return Ok(missoes);
		}
	}
}
