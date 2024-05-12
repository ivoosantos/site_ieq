using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.CreateCarousel;
using SiteCRM.Application.Commands.DeleteCarousel;
using SiteCRM.Application.Queries.GetAllCarousel;
using SiteCRM.Application.Queries.GetByIdCarousel;
using System.Runtime.InteropServices;

namespace SiteCRM.API.Controllers
{
    [Route("api/carousel")]
    [Authorize]
    public class CarouselController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarouselController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm]CreateCarouselCommand command)
        {
            var resp = await _mediator.Send(command);

            return Ok(resp);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCarouselCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpGet]
        [Route("listar")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var command = new GetAllCarouselQuery();
            var list = await _mediator.Send(command);

            foreach (var img in list)
            {
                img.imgByte = System.IO.File.ReadAllBytes(img.img);
            }

            return Ok(list);
        }

        [HttpGet]
        [Route("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var command = new GetByIdCarouselQuery(id);

            var resp = await _mediator.Send(command);

            if(resp == null) return NotFound();

            resp.imgByte = await System.IO.File.ReadAllBytesAsync(resp.img);

            return Ok(resp);
        }

        //TODO - Implementar Alteração
    }
}
