using MediatR;
using SiteCRM.Application.ViewModels;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetMissao
{
	public class GetMissaoQueryHandler : IRequestHandler<GetMissaoQuery, MissoesViewModel>
	{
		private readonly IMissoesRepository _missoesRepository;

		public GetMissaoQueryHandler(IMissoesRepository missoesRepository)
		{
			_missoesRepository = missoesRepository;
		}

		public async Task<MissoesViewModel> Handle(GetMissaoQuery request, CancellationToken cancellationToken)
		{
			var missao = await _missoesRepository.GetAsync(request.Id);

			if (missao == null) return null;

			return new MissoesViewModel(missao.Id, missao.titulo, missao.slug, missao.texto, missao.img, missao.dataPost);
		}
	}
}
