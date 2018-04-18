using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoeBem.Models.UsuarioViewModels
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Perfil { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
    }
}
