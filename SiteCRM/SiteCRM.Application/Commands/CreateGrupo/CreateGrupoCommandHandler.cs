using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateGrupo
{
    public class CreateGrupoCommandHandler : IRequestHandler<CreateGrupoCommand, int>
    {
        private readonly IGrupoRepository _grupoRepository;

        public CreateGrupoCommandHandler(IGrupoRepository grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }

        public async Task<int> Handle(CreateGrupoCommand request, CancellationToken cancellationToken)
        {
            var filePath = Path.Combine("Storage", request.File.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            request.File.CopyTo(fileStream);
            fileStream.FlushAsync().Wait();

            var grupo = new Grupo(filePath, request.titulo, request.descricao, request.slug, request.categoria, request.nome);

            await _grupoRepository.AddAsync(grupo);
            return grupo.Id;
        }
    }
}
