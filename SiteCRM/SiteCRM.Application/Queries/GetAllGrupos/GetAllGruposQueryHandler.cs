using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllGrupos
{
    public class GetAllGruposQueryHandler : IRequestHandler<GetAllGruposQuery, List<GrupoViewModel>>
    {
        private readonly IGrupoRepository _grupoRepository;

        public GetAllGruposQueryHandler(IGrupoRepository grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }

        public async Task<List<GrupoViewModel>> Handle(GetAllGruposQuery request, CancellationToken cancellationToken)
        {
            var findGroup = await _grupoRepository.GetAllAsync();

            var listGroup = findGroup
                .Select(g => new GrupoViewModel(g.Id, g.img, g.titulo, g.descricao, g.slug, g.categoria, g.nome))
                .ToList();

            listGroup.ForEach(g =>
            {
                g.imgByte = File.ReadAllBytes(g.img);
            });

            return listGroup;
        }
    }
}
