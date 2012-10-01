using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeAnota.Models
{
    public class Bloco : BaseEntity
    {
        public string Nome { get; set; }
        public List<Anotacao> Anotacoes { get; set; }
        public virtual IList<Usuario> Colaboradores { get; set; }
        public Usuario Proprietario { get; set; }

        public Bloco()
        {
            Colaboradores = new List<Usuario>();
            Anotacoes = new List<Anotacao>();
        }
    }
}