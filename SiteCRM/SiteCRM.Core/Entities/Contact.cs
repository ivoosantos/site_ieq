using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Contact : BaseEntity
    {
        public Contact(string nome, string telefone, string email, string mensagem, DateTime data, int idIgreja)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.mensagem = mensagem;
            this.data = data;
            this.IdIgreja = idIgreja;
        }

        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }
        public DateTime data { get; set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }
    }
}
