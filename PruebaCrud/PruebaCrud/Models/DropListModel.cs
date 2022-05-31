using Microsoft.AspNetCore.Mvc.Rendering;

namespace PruebaCrud.Models
{
    public class DropListModel
    {
        //Modelo que permite la entrada y salida de datos de la vista SelectGiros
        public List<SelectListItem> ciudadesSelectList { get; set; }
        public List<SelectListItem> paisesSelectList { get; set; }
        public List<GirosModel> _listGiros { get; set; }
    }
}
