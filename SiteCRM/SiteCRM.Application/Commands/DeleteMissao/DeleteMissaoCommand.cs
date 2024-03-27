using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteMissao
{
	public class DeleteMissaoCommand : IRequest<Unit>
	{
        public int Id { get; private set; }

		public DeleteMissaoCommand(int id)
		{
			Id = id;
		}
	}
}
