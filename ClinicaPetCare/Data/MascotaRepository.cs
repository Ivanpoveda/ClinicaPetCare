using System.Collections.Generic;
using System.Linq;
using ClinicaPetCare.Models;
namespace ClinicaPetCare.Data
{
    public class MascotaRepository
    {
        private readonly List<Mascota> _mascotas = new();
        private int _nextId = 1;


        public void AgregarMascota(Mascota m)
        {
            m.Id = _nextId++;
            _mascotas.Add(m);
        }


        public List<Mascota> ObtenerMascotas()
        {
            return _mascotas.ToList();
        }
    }
}