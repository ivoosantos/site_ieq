using MediatR;
using SiteCRM.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteMissao
{
	public class DeleteMissaoCommandHandler : IRequestHandler<DeleteMissaoCommand, Unit>
	{
		private readonly IMissoesRepository _missoesRepository;

		public DeleteMissaoCommandHandler(IMissoesRepository missoesRepository)
		{
			_missoesRepository = missoesRepository;
		}

		public async Task<Unit> Handle(DeleteMissaoCommand request, CancellationToken cancellationToken)
		{
			var missao = await _missoesRepository.GetAsync(request.Id);

			await _missoesRepository.DeleteAsync(missao);

			return Unit.Value;
		}
	}
}
