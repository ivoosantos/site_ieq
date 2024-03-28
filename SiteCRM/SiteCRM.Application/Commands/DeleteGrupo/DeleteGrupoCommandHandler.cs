using MediatR;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteGrupo
{
    public class DeleteGrupoCommandHandler : IRequestHandler<DeleteGrupoCommand, Unit>
    {
        private readonly IGrupoRepository _grupoRepository;

        public DeleteGrupoCommandHandler(IGrupoRepository grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }

        public async Task<Unit> Handle(DeleteGrupoCommand request, CancellationToken cancellationToken)
        {
            var grupo = await _grupoRepository.GetByIdAsync(request.Id);

            await _grupoRepository.DeleteAsync(grupo);

            return Unit.Value;
        }
    }
}
