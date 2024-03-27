using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class FeatureViewModel
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string slug { get; set; }
        public string descricao { get; set; }
        public string img { get; set; }

        public FeatureViewModel(int id_, string titulo_, string slug_, string descricao_, string img_)
        {
            this.id = id_;
            this.titulo = titulo_;
            this.slug = slug_;
            this.descricao = descricao_;
            this.img = img_;
        }
    }
}
