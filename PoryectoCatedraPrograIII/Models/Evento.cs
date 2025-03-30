using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PoryectoCatedraPrograIII.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public string NombreEvento { get; set; }
        public string TipoEvento { get; set; }
        public string Direccion { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public decimal PrecioEntrada { get; set; }
        public string Fotografia { get; set; }
        public string Descripcion { get; set; }
        public string VideoUrl { get; set; }
        public int NegocioParticipanteId { get; set; }
        [ForeignKey("NegocioParticipanteId")]
        public Tiendas Tienda { get; set; }
        public DateTime CreadoEn { get; set; } = DateTime.Now;
        public DateTime ActualizadoEn { get; set; } = DateTime.Now;
    }
}
