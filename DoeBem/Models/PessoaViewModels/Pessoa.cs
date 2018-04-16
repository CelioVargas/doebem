namespace DoeBem.Models.PessoaViewModels
{
    public class Pessoa : BaseModel
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
    }
}
