﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.CreateMissao;
using SiteCRM.Application.Queries.GetAllMissoes;
using SiteCRM.Application.Queries.GetMissao;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace SiteCRM.API.Controllers
{
	[Route("api/missoes")]
	[ApiController]
	[Authorize]
	public class MissoesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public MissoesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateMissaoCommand command)
		{
			var filePath = Path.Combine("Storage", command.File.FileName);
			using Stream fileStream = new FileStream(filePath, FileMode.Create);
            command.File.CopyTo(fileStream);
			fileStream.FlushAsync().Wait();
			command.img = filePath;

			var resp = await _mediator.Send(command);
			
			return Ok(resp);
		}

		[HttpGet]
        [AllowAnonymous]
		[Route("{id}")]
        public async Task<IActionResult> GetMissao(int id)
		{
			var mission = new GetMissaoQuery(id);

			var resp = await _mediator.Send(mission);

			var dataBytes = System.IO.File.ReadAllBytes(resp.img);
			//resp.img = string.Join(",", dataBytes); 
			//resp.imgByte = dataBytes;
			//byte[] bytes = Convert.FromBase64String(resp.img);
			//Image image;
			//using (var stream = new MemoryStream(dataBytes))
			resp.imgByte = dataBytes;

			//resp.File = (IFormFile)File(dataBytes, "image/png");
			//await using var memoryStream = new MemoryStream(dataBytes);
			//await resp.File.CopyToAsync(memoryStream);
			//dataBytes = memoryStream.ToArray();

			return Ok(resp);
			//return File(dataBytes, "image/png");
		}

		[HttpGet]
        [AllowAnonymous]
        [Route("listar")]
		public async Task<IActionResult> GetAll()
		{
			var command = new GetAllMissoesQuery();

			var listMissoes = await _mediator.Send(command);

			foreach ( var m in listMissoes)
			{
				m.imgByte = System.IO.File.ReadAllBytes(m.img);
			}

			return Ok(listMissoes);
		}

        //TODO - Implementar o Delete
        //TODO - Implementar Alteração
    }
}
