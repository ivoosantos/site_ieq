using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateMissao
{
	public class CreateMissaoCommand : IRequest<int>
	{
		public string titulo { get; set; }
		public string slug { get; set; }
		public string texto { get; set; }
		public string img { get; set; }
		public DateTime dataPost { get; set; } = DateTime.Now;
        public IFormFile File { get; set; }
    }
}
