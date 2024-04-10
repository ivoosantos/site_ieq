﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.Commands.CreateContact
{
    public class CreateContactCommand : IRequest<int>
    {
        public string nome { get; set; } = string.Empty;
        public string telefone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string mensagem { get; set; } = string.Empty;
        public DateTime data { get; set; }
        public bool IsPrayer { get; set; }
        public int IdIgreja { get; set; } = 0;
    }
}
