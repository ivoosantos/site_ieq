using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class ContactViewModel
    {
        public ContactViewModel(int id, string nome, string telefone, string email, string mensagem, DateTime data, bool isPrayer, int idIgreja)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.mensagem = mensagem;
            this.data = data;
            this.isPrayer = isPrayer;
            this.idIgreja = idIgreja;
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }
        public DateTime data { get; set; }
        public bool isPrayer { get; set; }
        public int idIgreja { get; set; }
    }
}
