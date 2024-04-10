using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.CreateContact;
using SiteCRM.Application.Commands.DeleteContact;
using SiteCRM.Application.Queries.GetAllContact;
using SiteCRM.Application.Queries.GetByIdContact;
using SiteCRM.Application.ViewModels;

namespace SiteCRM.API.Controllers
{
    [Route("api/contact")]
    [Authorize]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody]CreateContactCommand command)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState.IsValid);
            command.data = DateTime.Now.ToUniversalTime();
            var insert = await _mediator.Send(command);

            return Ok(insert);
        }

        [HttpGet]
        [Route("listar")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllContactQuery();
            var listConotacts = await _mediator.Send(query);

            return Ok(listConotacts);
        }

        [HttpGet]
        [Route("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdContactQuery(id);

            var contact = await _mediator.Send(query);

            return Ok(contact);
            //new ContactViewModel(contact.id, contact.nome, contact.telefone,
            //                      contact.email, contact.mensagem, contact.data,
            //                      contact.isPrayer, contact.idIgreja)
        }

        [HttpDelete]
        [Route("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteContactCommand(id);

            return Ok(await _mediator.Send(command));
        }
    }
}
