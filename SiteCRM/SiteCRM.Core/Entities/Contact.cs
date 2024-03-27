using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Contact : BaseEntity
    {
        public Contact(string nome, string telefone, string email, string mensagem, DateTime data)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.mensagem = mensagem;
            this.data = data;
        }

        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }
        public DateTime data { get; set; }

        //public Contact(string _nome, string _telefone, string _email, string _mensagem, DateTime _data)
        //{
        //    this.nome = _nome;
        //    this.telefone = _telefone;
        //    this.email = _email;
        //    this.mensagem = _mensagem;
        //    this.data = _data;
        //}
    }
}
