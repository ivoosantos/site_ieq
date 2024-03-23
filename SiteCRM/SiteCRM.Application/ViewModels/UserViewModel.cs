using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class UserViewModel
    {
		public UserViewModel(int id, string user_email, string user_nome, string user_tipo)
		{
			this.id = id;
			this.user_email = user_email;
			this.user_nome = user_nome;
			this.user_tipo = user_tipo;
		}

		public int id { get; set; }
        public string user_email { get; set; }
        public string user_nome { get; set; }
        public string user_tipo { get; set; }
    }
}
