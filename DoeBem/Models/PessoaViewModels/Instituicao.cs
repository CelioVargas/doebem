namespace DoeBem.Models.PessoaViewModels
{
    public class Instituicao : PessoaJuridica
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
        public string VideoUrl { get; set; }
    }
}
