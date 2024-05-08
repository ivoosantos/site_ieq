using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Carousel : BaseEntity
    {
        public Carousel(string img, string titulo, string informacao, string? end_url, bool active_img, int idIgreja)
        {
            this.img = img;
            this.titulo = titulo;
            this.informacao = informacao;
            this.end_url = end_url;
            this.active_img = active_img;
            this.IdIgreja = idIgreja;
        }

        public string? img { get; set; }
        public string titulo { get; set; }
        public string informacao { get; set; }
        public string? end_url { get; set; }
        public bool active_img { get; set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }
    }
}
