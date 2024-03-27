using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Application.ViewModels
{
    public class SobreViewModel
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }

        public SobreViewModel(int id_, string titulo_, string descricao_, string tipo_)
        {
            this.id = id_;
            this.titulo = titulo_;
            this.descricao = descricao_;
            this.tipo = tipo_;
        }
    }
}
