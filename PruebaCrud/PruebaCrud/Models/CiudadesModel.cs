using System.ComponentModel.DataAnnotations;

namespace PruebaCrud.Models
{
    //Modelod e datos de la tabla ciudades
    public class CiudadesModel
    {
        public int id_ciudad { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public int id_pais { get; set; }
    }
}
