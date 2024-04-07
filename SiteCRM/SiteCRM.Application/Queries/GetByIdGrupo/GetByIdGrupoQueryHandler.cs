using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetByIdGrupo
{
    public class GetByIdGrupoQueryHandler : IRequestHandler<GetByIdGrupoQuery, GrupoViewModel>
    {
        private readonly IGrupoRepository _grupoRepository;

        public GetByIdGrupoQueryHandler(IGrupoRepository grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }

        public async Task<GrupoViewModel> Handle(GetByIdGrupoQuery request, CancellationToken cancellationToken)
        {
            var group = await _grupoRepository.GetByIdAsync(request.Id);

            if (group is null) return null;

            var resp = new GrupoViewModel(group.Id, group.img, group.titulo, 
                                         group.descricao, group.slug, group.categoria, group.nome);
            
            resp.imgByte = System.IO.File.ReadAllBytes(resp.img);

            return resp;
        }
    }
}
