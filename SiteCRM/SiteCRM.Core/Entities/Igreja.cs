using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Igreja : BaseEntity
    {
        public string Nome { get; private set; } = string.Empty;
        public string NomeFantasia { get; private set; } = string.Empty;
        public string Responsavel { get; private set; } = string.Empty;
        public string Contato { get; private set; } = string.Empty;
    }
}
