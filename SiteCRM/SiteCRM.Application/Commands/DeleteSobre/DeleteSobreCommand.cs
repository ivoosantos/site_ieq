using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.DeleteSobre
{
	public class DeleteSobreCommand : IRequest<Unit>
	{
		public DeleteSobreCommand(int id)
		{
			Id = id;
		}

        public int Id { get; private set; }
    }
}
