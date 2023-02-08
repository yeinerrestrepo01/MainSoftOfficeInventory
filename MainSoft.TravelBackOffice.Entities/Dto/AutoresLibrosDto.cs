namespace MainSoft.TravelBackOffice.Entities.Dto
{
    /// <summary>
    /// Objeto de transferencia de datos de AutoresLibros
    /// </summary>
    public class AutoresLibrosDto
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public int IsbnLibro { get; set; }
    }
}
