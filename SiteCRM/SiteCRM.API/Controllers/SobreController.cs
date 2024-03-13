using MediatR;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.CreateSobre;
using SiteCRM.Application.Queries.GetAllSobres;
using System.Runtime.InteropServices;

namespace SiteCRM.API.Controllers
{
    [Route("api/sobres")]
    public class SobreController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SobreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateSobreCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var command = new GetAllSobresQuery();

            var sobre = await _mediator.Send(command);

            return Ok(sobre);
        }
    }
}
