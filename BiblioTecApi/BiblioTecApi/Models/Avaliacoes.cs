namespace BiblioTecApi.Models
{
    public class Avaliacoes
    {
        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public int Livro_Id { get; set; }
        public Decimal Nota { get; set; }
        public string comentario { get; set; }
        public DateTime Data_Avaliacao{ get; set; }
    }
}
