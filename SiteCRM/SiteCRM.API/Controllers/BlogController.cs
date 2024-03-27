﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiteCRM.Application.Commands.CreateBlog;
using SiteCRM.Application.Queries.GetAllBlog;
using SiteCRM.Application.Queries.GetByIdBlog;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Entities;

namespace SiteCRM.API.Controllers
{
    [Route("api/blog")]
    [Authorize]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm]BlogViewModel blogViewModel)
        {
            var filePath = Path.Combine("Storage", blogViewModel.File.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            blogViewModel.File.CopyTo(fileStream);
            fileStream.FlushAsync().Wait();

            var command = new CreateBlogCommand
            {
                titulo = blogViewModel.titulo,
                slug = blogViewModel.slug,
                texto = blogViewModel.texto,
                img = filePath
            };

            var resp =  await _mediator.Send(command);

            return Ok(resp);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var blog = new GetByIdBlogQuery(id);

            var respBlog = await _mediator.Send(blog);

            respBlog.imgByte = await System.IO.File.ReadAllBytesAsync(respBlog.img);

            return Ok(respBlog);
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> GetAll()
        {
            var command = new GetAllBlogQuery();

            var resp = await _mediator.Send(command);

            foreach (var img in resp)
            {
                img.imgByte = System.IO.File.ReadAllBytes(img.img);
            }

            return Ok(resp);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var blog = new GetByIdBlogQuery(id);
            var del = await _mediator.Send(blog);
            return NoContent();
        }
    }
}
