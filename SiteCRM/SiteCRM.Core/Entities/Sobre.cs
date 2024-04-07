using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Core.Entities
{
    public class Sobre : BaseEntity
    {
        public Sobre(string titulo, string descricao, string tipo, int idIgreja)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.tipo = tipo;
            this.IdIgreja = idIgreja;
        }

        public string titulo { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }
        public int IdIgreja { get; private set; }
        public Igreja Igreja { get; private set; }

        public void Update(string _titulo,  string _descricao, string _tipo)
        {
            titulo = _titulo;
            descricao = _descricao;
            tipo = _tipo;
        }

    }
}
