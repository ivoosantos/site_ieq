using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateGrupo
{
    public class CreateGrupoCommand : IRequest<int>
    {
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string slug { get; set; }
        public string categoria { get; set; }
        public string nome { get; set; }
        public virtual IFormFile File { get; set; }
    }
}
