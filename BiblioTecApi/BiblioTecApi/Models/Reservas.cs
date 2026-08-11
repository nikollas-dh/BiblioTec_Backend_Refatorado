namespace BiblioTecApi.Models
{
    public class Reservas
    {
        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public int Livro_Id { get; set; }
        public DateTime Data_Retirada { get; set; }
        public DateTime Data_Devolucao{ get; set; }
        public DateTime Criado_em { get; set; }
        

    }
}
