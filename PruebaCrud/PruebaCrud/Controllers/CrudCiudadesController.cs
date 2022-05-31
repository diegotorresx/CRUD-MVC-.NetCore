using Microsoft.AspNetCore.Mvc;
using PruebaCrud.Database;
using PruebaCrud.Models;

namespace PruebaCrud.Controllers
{
    public class CrudCiudadesController : Controller
    {
        DataLayer _data = new DataLayer();
        public IActionResult SelectCiudades()
        {
            var ciudadesList = _data.SelectAllCiudades();
            return View(ciudadesList);
        }
        public IActionResult InsertCiudades()
        {

            return View();
        }

        [HttpPost]
        public IActionResult InsertCiudades(CiudadesModel ciudad)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var response = _data.InsertCiudad(ciudad);
            if (response == 1)
            {
                return RedirectToAction("SelectCiudades");
            }
            else
            {
                return View();
            }

        }
        public IActionResult UpdateCiudades(int id_ciudad)
        {
            var ciudadSelected = _data.SelectAOneCity(id_ciudad);
            return View(ciudadSelected);
        }
        [HttpPost]
        public IActionResult UpdateCiudades(CiudadesModel ciudad)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            int response = _data.UpdateCiudad(ciudad);
            if (response == 1)
            {
                return RedirectToAction("SelectCiudades");
            }
            else
            {
                return View();
            }
        }
        public IActionResult DeleteCiudades(int id_ciudad)
        {
            var ciudad = _data.SelectAOneCity(id_ciudad);
            return View(ciudad);
        }
        [HttpPost]
        public IActionResult DeleteCiudades(CiudadesModel ciudad)
        {

            int response = _data.DeleteCiudad(ciudad.id_ciudad);
            if (response == 1)
            {
                return RedirectToAction("SelectCiudades");
            }
            else
            {
                return View();
            }
        }
    }
}
