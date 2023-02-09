using MainSoft.TravelBackOffice.Entities.Const;
using System.Net;

namespace MainSoft.TravelBackOffice.Entities.Dto
{
    /// <summary>
    /// Respuesta generica para las transacciones
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RespuestaGenerica<T>
    {
        public RespuestaGenerica()
        {
            this.EstadoHttp = HttpStatusCode.OK;
            this.Exitoso = true;
            this.Mensaje = Mensajes.MensajeExitoso;
        }
        public bool Exitoso { get; set; }
        public string? Mensaje { get; set; }
        public HttpStatusCode EstadoHttp { get; set; }
        public T? Respuesta { get; set; }
    }
}
