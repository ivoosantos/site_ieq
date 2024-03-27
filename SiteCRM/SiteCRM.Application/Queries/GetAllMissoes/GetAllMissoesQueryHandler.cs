using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetAllMissoes
{
	public class GetAllMissoesQueryHandler : IRequestHandler<GetAllMissoesQuery, List<MissoesViewModel>>
	{
		private readonly IMissoesRepository _missoesRepository;

		public GetAllMissoesQueryHandler(IMissoesRepository missoesRepository)
		{
			_missoesRepository = missoesRepository;
		}

		public async Task<List<MissoesViewModel>> Handle(GetAllMissoesQuery request, CancellationToken cancellationToken)
		{
			var listMissoes = await _missoesRepository.GetAllAsync();

			var missoes = listMissoes
				.Select(m => new MissoesViewModel(m.Id, m.titulo, m.slug, m.texto, m.img, m.dataPost))
				.ToList();

			return missoes;
		}
	}
}
