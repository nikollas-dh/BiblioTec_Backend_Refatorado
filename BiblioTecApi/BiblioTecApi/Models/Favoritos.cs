namespace BiblioTecApi.Models
{
    public class Favoritos
    {
        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public int Livro_Id { get; set; }
        public DateTime Data_Favoritado { get; set; }
    }
}
