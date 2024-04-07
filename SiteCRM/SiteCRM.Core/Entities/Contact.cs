using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Contact : BaseEntity
    {
        public Contact(string nome, string telefone, string email, string mensagem, DateTime data, bool isPrayer, int idIgreja)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.mensagem = mensagem;
            this.data = data;
            this.IsPrayer = isPrayer;
            this.IdIgreja = idIgreja;
        }

        public string nome { get; private set; }
        public string telefone { get; private set; }
        public string email { get; private set; }
        public string mensagem { get; private set; }
        public DateTime data { get; private set; }
        public bool IsPrayer { get; private set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }
    }
}
