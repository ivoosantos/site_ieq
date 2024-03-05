using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Sobre : BaseEntity
    {
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }

        public Sobre(string titulo_, string descricao_, string tipo_)
        {
            this.titulo = titulo_;
            this.descricao = descricao_;
            this.tipo = tipo_;
        }

        public void Update(string _titulo,  string _descricao, string _tipo)
        {
            titulo = _titulo;
            descricao = _descricao;
            tipo = _tipo;
        }

    }
}
