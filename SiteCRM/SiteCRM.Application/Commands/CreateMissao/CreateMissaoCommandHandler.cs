using MediatR;
using SiteCRM.Core.Entities;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateMissao
{
	public class CreateMissaoCommandHandler : IRequestHandler<CreateMissaoCommand, int>
	{
		private readonly IMissoesRepository _missoesRepository;

		public CreateMissaoCommandHandler(IMissoesRepository missoesRepository)
		{
			_missoesRepository = missoesRepository;
		}

		public async Task<int> Handle(CreateMissaoCommand request, CancellationToken cancellationToken)
		{
			var missao = new Missoes(request.titulo, request.slug, request.texto, request.img);
			//var missao = new Missoes();

			await _missoesRepository.AddAsync(missao);

			return missao.Id;
		}
	}
}
