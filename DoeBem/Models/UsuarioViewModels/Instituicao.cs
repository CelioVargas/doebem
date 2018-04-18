using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoeBem.Models.UsuarioViewModels
{
    public class Instituicao : Usuario
    {
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
        public string VideoUrl { get; set; }
    }
}
