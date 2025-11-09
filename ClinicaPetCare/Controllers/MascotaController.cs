using Microsoft.AspNetCore.Mvc;
using ClinicaPetCare.Data;
using ClinicaPetCare.Models;
namespace ClinicaPetCare.Controllers
{
    public class MascotaController : Controller
    {
        private readonly MascotaRepository _repo;


        public MascotaController(MascotaRepository repo)
        {
            _repo = repo;
        }


        public IActionResult Index()
        {
            var lista = _repo.ObtenerMascotas();
            return View(lista);
        }


        public IActionResult Registrar()
        {
            return View(new Mascota { FechaIngreso = System.DateTime.Now.Date });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Guardar(Mascota model)
        {
            if (!ModelState.IsValid)
            {
                return View("Registrar", model);
            }


            _repo.AgregarMascota(model);
            TempData["Mensaje"] = "Mascota registrada con éxito.";
            return RedirectToAction("Index");
        }
    }
}
