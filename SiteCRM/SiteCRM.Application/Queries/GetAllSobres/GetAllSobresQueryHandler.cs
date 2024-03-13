using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllSobres
{
    public class GetAllSobresQueryHandler : IRequestHandler<GetAllSobresQuery, List<SobreViewModel>>
    {
        private readonly ISobreRepository _sobreRepository;
        public GetAllSobresQueryHandler(ISobreRepository sobreRepository)
        {
            _sobreRepository = sobreRepository;
        }
        public async Task<List<SobreViewModel>> Handle(GetAllSobresQuery request, CancellationToken cancellationToken)
        {
            var sobres = await _sobreRepository.GetAllAsync();

            var sobreViewModel = sobres.Select(s => new SobreViewModel(s.Id, s.titulo, s.descricao, s.tipo)).ToList();

            return sobreViewModel;
        }
    }
}
