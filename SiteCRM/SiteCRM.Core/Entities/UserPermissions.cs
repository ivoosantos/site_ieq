using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
	public class UserPermissions : BaseEntity
	{
		public UserPermissions(string user_id, string json_data, int idIgreja)
		{
			this.user_id = user_id;
			this.json_data = json_data;
			this.IdIgreja = idIgreja;
		}

		public string user_id { get; private set; }
        public string json_data { get; private set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }

        public void Update(string user_id, string json_data)
		{
			this.user_id = user_id;
			this.json_data = json_data;
		}
    }
}
