using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PruebaCrud.Database;
using PruebaCrud.Models;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PruebaCrud.Controllers
{
    public class CrudGirosController : Controller
    {
        DataLayer _data = new DataLayer();
        DropListModel _dropListModel = new DropListModel();

        //Metodo para generar la vista de InsertGiros
        public IActionResult SelectGiros()
        {
            _dropListModel._listGiros = _data.SelectAllGiros();
            ViewBag.Validation = false;
            _dropListModel.paisesSelectList = paisesListItem();
            return View(_dropListModel);
        }
        //Metodo para recibir las acciones relizadas en al vista SelectGiros
        [HttpPost]
        public IActionResult SelectGiros([Optional] string paisesSelectList, [Optional] string ciudadesSelectList)
        {
            _dropListModel.paisesSelectList = paisesListItem();

            if (!string.IsNullOrEmpty(paisesSelectList))
            {
                _data.UpdatePaisSelected(paisesSelectList);
                ViewBag.Validation = true;
                _dropListModel.ciudadesSelectList = ciudadesListItem(Int32.Parse(paisesSelectList));
            }
            if (!string.IsNullOrEmpty(ciudadesSelectList))
            {
                string id_pais = _data.SelectPaisSelected();
                ViewBag.Validation = true;
                _dropListModel.ciudadesSelectList = ciudadesListItem(Int32.Parse(id_pais));
                _dropListModel._listGiros = _data.SelectGiros(Int32.Parse(ciudadesSelectList));
            }
            else
            {
                _dropListModel._listGiros = _data.SelectAllGiros();
            }
            return View(_dropListModel);
        }

        //Metodo para generar la vista de InsertGiros
        public IActionResult InsertGiros()
        {

            return View();
        }
        //Metodo para recibir las acciones relizadas en al vista InsertGiros
        [HttpPost]
        public IActionResult InsertGiros(GirosModel giro)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var response = _data.InsertGiros(giro);
            if (response == 1)
            {
                return RedirectToAction("SelectGiros");
            }
            else
            {
                return View();
            }

        }
        //Metodo para generar la vista de UpdateGiros
        public IActionResult UpdateGiros(int GIR_GIRO_ID)
        {
            var giroSelected = _data.SelectOneGiros(GIR_GIRO_ID);
            return View(giroSelected);
        }
        //Metodo para recibir las acciones relizadas en al vista UpdateGiros
        [HttpPost]
        public IActionResult UpdateGiros(GirosModel giro)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            int response = _data.UpdatetGiros(giro);
            if (response == 1)
            {
                return RedirectToAction("SelectGiros");
            }
            else
            {
                return View();
            }
        }
        //Metodo para generar la vista de DeleteGiros
        public IActionResult DeleteGiros(int GIR_GIRO_ID)
        {
            var giro = _data.SelectOneGiros(GIR_GIRO_ID);
            return View(giro);
        }
        //Metodo para recibir las acciones relizadas en al vista DeleteGiros
        [HttpPost]
        public IActionResult DeleteGiros(GirosModel giro)
        {

            int response = _data.DeleteGiros(giro.GIR_GIRO_ID);
            if (response == 1)
            {
                return RedirectToAction("SelectGiros");
            }
            else
            {
                return View();
            }
        }
        //Metodo para llenado del SelectListItem que será enviado a la vista SelectGiros.cshtml para mostrar el DropDownList Paises
        private List<SelectListItem> paisesListItem()
        {
            List<SelectListItem> paisesSelectItemList = new List<SelectListItem>();

            List<PaisesModel> paises = _data.SelectPaises();

            paisesSelectItemList = paises.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.nombre.ToString(),
                    Value = d.id_pais.ToString(),
                    Selected = false
                };
            });
            return paisesSelectItemList;
        }

        //Metodo para llenado del SelectListItem que será enviado a la vista SelectGiros.cshtml para mostrar el ropownList Ciudaes
        private List<SelectListItem> ciudadesListItem(int idCiudad)
        {
            List<SelectListItem> ciudadsSelectItemList = new List<SelectListItem>();

            List<CiudadesModel> ciudades = _data.SelectCiudades(idCiudad);

            ciudadsSelectItemList = ciudades.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.nombre.ToString(),
                    Value = d.id_ciudad.ToString(),
                    Selected = false
                };
            });
            return ciudadsSelectItemList;
        }
    }
}
