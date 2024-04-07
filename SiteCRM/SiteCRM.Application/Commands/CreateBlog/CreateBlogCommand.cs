using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateBlog
{
    public class CreateBlogCommand : IRequest<int>
    {
        public string titulo { get; set; } = string.Empty;
        public string slug { get; set; } = string.Empty;
        public string texto { get; set; } = string.Empty;
        public string img { get; set; } = string.Empty;
        public DateTime dataPost { get; set; }
        public IFormFile File { get; set; }
        public int idIgreja { get; set; }
    }
}
