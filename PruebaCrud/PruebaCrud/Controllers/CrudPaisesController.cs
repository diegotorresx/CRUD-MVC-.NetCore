using Microsoft.AspNetCore.Mvc;
using PruebaCrud.Database;
using PruebaCrud.Models;

namespace PruebaCrud.Controllers
{
    public class CrudPaisesController : Controller
    {
        DataLayer _data = new DataLayer();
        public IActionResult SelectPaises()
        {
            var paisesList = _data.SelectPaises();
            return View(paisesList);
        }
        public IActionResult Insert()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Insert(PaisesModel pais)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var response = _data.InsertPaises(pais);
            if (response == 1)
            {
                return RedirectToAction("SelectPaises");
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult UpdatePaises(int id_pais)
        {
            var pais = _data.SelectPais(id_pais);
            return View(pais);
        }
        [HttpPost]
        public IActionResult UpdatePaises(PaisesModel pais)
        {
            
            if (!ModelState.IsValid)
            {
                return View();
            }
            int response = _data.UpdatePaises(pais);
            if (response == 1)
            {
                return RedirectToAction("SelectPaises");
            }
            else
            {
                return View();
            }
        }
        public IActionResult DeletePaises(int id_pais)
        {
            var pais = _data.SelectPais(id_pais);
            return View(pais);
        }
        [HttpPost]
        public IActionResult DeletePaises(PaisesModel pais)
        {

            int response = _data.DeletePaises(pais.id_pais);
            if (response == 1)
            {
                return RedirectToAction("SelectPaises");
            }
            else
            {
                return View();
            }
        }
    }
}
