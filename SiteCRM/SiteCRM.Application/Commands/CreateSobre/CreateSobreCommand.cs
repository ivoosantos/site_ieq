using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateSobre
{
    public class CreateSobreCommand : IRequest<int>
    {
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }
        public int idIgreja { get; set; }
    }
}
