using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateContact
{
    public class CreateContactCommand : IRequest<int>
    {
        public string nome { get; private set; } = string.Empty;
        public string telefone { get; private set; } = string.Empty;
        public string email { get; private set; } = string.Empty;
        public string mensagem { get; private set; } = string.Empty;
        public DateTime data { get; private set; }
        public bool IsPrayer { get; private set; }
        public int IdIgreja { get; private set; } = 0;
    }
}
