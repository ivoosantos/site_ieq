using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateUser
{
	public class CreateUserCommand : IRequest<Unit>
	{
		public string user_email { get; set; }
		public string user_nome { get; set; }
		public string user_senha { get; set; }
		public string user_tipo { get; set; }
        public int idIgreja { get; set; }
    }
}
