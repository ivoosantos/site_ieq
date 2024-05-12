using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.CreateGrupo;
using SiteCRM.Application.Commands.DeleteGrupo;
using SiteCRM.Application.Queries.GetAllGrupos;
using SiteCRM.Application.Queries.GetByIdBlog;
using SiteCRM.Application.Queries.GetByIdGrupo;

namespace SiteCRM.API.Controllers
{
    [Route("api/grupo")]
    [Authorize]
    public class GrupoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GrupoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm]CreateGrupoCommand command)
        {
            var resp = await _mediator.Send(command);

            return Ok(resp);
        }

        [Route("{id}")]
        [HttpGet]
        [AllowAnonymous]
        [ActionName(nameof(GetAsync))]
        public async Task<IActionResult> GetAsync(int id)
        {
            var group = new GetByIdGrupoQuery(id);

            var resp = await _mediator.Send(group);

            if (resp is null) return NotFound();

            var dataBytes = System.IO.File.ReadAllBytes(resp.img);

            resp.imgByte = dataBytes;

            return Ok(resp);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var group = new DeleteGrupoCommand(id);

            await _mediator.Send(group);

            return NoContent();
        }

        [Route("listar")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var command = new GetAllGruposQuery();
            var listGroup = await _mediator.Send(command);

            return Ok(listGroup);
        }

        //TODO - Implementar Alteração
    }
}
