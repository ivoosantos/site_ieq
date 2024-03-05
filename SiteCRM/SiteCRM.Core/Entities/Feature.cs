using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Feature : BaseEntity
    {
        public string titulo { get; set; }
        public string slug { get; set; }
        public string descricao { get; set; }
        public string img { get; set; }

        public Feature(string titulo_, string slug_, string descricao_, string img_)
        {
            this.titulo = titulo_;
            this.slug = slug_;
            this.descricao = descricao_;
            this.img = img_;
        }
    }
}
