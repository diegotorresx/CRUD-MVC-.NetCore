using System.ComponentModel.DataAnnotations;

namespace PruebaCrud.Models
{
    //Modelo de datos de la tabla paises
    public class PaisesModel
    {
        public int id_pais { get; set; }
        [Required]
        public string nombre { get; set; }
    }
}
