using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Blog : BaseEntity
    {
        public Blog(string titulo, string slug, string texto, string img)
        {
            this.titulo = titulo;
            this.slug = slug;
            this.texto = texto;
            this.img = img;
            this.dataPost = DateTime.Now.ToUniversalTime();
        }

        public string titulo { get; set; } = string.Empty;
        public string slug { get; set; } = string.Empty;
        public string texto { get; set; } = string.Empty;
        public string img { get; set; }
        public DateTime dataPost { get; set; }
    }
}
