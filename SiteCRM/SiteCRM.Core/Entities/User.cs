using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string user_email, string user_nome, string user_senha, string user_tipo, int idIgreja)
        {
            this.user_email = user_email;
            this.user_nome = user_nome;
            this.user_senha = user_senha;
            this.user_tipo = user_tipo;
            this.IdIgreja = idIgreja;
        }

        public string user_email { get; set; }
        public string user_nome { get; set; }
        public string user_senha { get; set; }
        public string user_tipo { get; set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }
    }
}
