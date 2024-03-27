using MediatR;
using SiteCRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Queries.GetMissao
{
	public class GetMissaoQuery : IRequest<MissoesViewModel>
	{
        public int Id { get; private set; }

		public GetMissaoQuery(int id)
		{
			Id = id;
		}
	}
}
