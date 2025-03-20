namespace IperonprevAPI.Dominio
{
    public class Sistema
    {
        public int Id { get; set; }

        public string? NomeSistema { get; set; }

        public string? LinkSistema { get; set; } 

        public int TipoSistema { get; set; }

        public string? DescricaoSistema { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataExclusao { get; set; }

        public bool IsExcluir { get; set; }
    }
}
