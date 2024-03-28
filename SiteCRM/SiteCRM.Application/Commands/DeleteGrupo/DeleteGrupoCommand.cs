using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteGrupo
{
    public class DeleteGrupoCommand : IRequest<Unit>
    {
        public int Id { get; private set; }

        public DeleteGrupoCommand(int id)
        {
            Id = id;
        }
    }
}
