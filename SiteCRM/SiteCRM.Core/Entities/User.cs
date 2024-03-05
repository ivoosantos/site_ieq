using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class User : BaseEntity
    {
        public string user_email { get; set; }
        public string user_nome { get; set; }
        public string user_senha { get; set; }
        public string user_tipo { get; set; }

        public User(string user_email_, string user_nome_, string user_senha_, string user_tipo_)
        {
            this.user_email = user_email_;
            this.user_nome = user_nome_;
            this.user_senha = user_senha_;
            this.user_tipo = user_tipo_;
        }
    }
}
