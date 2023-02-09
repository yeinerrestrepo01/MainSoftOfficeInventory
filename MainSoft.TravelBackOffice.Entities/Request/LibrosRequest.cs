namespace MainSoft.TravelBackOffice.Entities.Request
{
    public class LibrosRequest
    {
        public int Isbn { get; set; }
        public int EditorialId { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopsis { get; set; }
        public int NPaginas { get; set; }
    }
}
