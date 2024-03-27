using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class ContactViewModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }
        public DateTime data { get; set; }

        public ContactViewModel(int id_, string nome_, string telefone_, string email_, string mensagem_, DateTime data_)
        {
            this.id = id_;
            this.nome = nome_;
            this.telefone = telefone_;
            this.email = email_;
            this.mensagem = mensagem_;
            this.data = data_;
        }
    }
}
