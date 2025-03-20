namespace IperonprevAPI.Dominio
{
    public class Noticia
    {
        public int Id { get; set; }

        public int PublicacaoId { get; set; }

        public string? Titulo { get; set; }

        public bool Destaque { get; set; }

        public string? HTMLNoticia { get; set; }

        public string? UrlsImage { get; set; }

        public string? ImagePrincipal { get; set; }

        public int CategoriaId { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool? IsExcluir { get; set; }

        public DateTime? DataExclusao { get; set; }
    }
}
