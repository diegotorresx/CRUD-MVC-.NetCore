using System.ComponentModel.DataAnnotations;

namespace PruebaCrud.Models
{
    //Modelo de datos de la tabla giros
    public class GirosModel
    {
        public int GIR_GIRO_ID { get; set; }
        [Required]
        public string GIR_RECIBO { get; set; }
        [Required]
        public int GIR_CIUDAD_ID { get; set;}
    }
}
