namespace DoeBem.Models.PessoaViewModels
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
    }
}
