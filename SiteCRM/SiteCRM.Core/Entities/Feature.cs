using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Feature : BaseEntity
    {
        public Feature(string titulo, string slug, string descricao, string img, int idIgreja)
        {
            this.titulo = titulo;
            this.slug = slug;
            this.descricao = descricao;
            this.img = img;
            this.IdIgreja = idIgreja;
        }

        public string titulo { get; set; }
        public string slug { get; set; }
        public string descricao { get; set; }
        public string img { get; set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }
    }
}
