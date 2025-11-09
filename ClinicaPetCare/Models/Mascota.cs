using System;
using System.ComponentModel.DataAnnotations;
namespace ClinicaPetCare.Models
{
    public class Mascota
    {
        public int Id { get; set; }


[Required(ErrorMessage = "El nombre de la mascota es obligatorio")]
[MinLength(2, ErrorMessage = "El nombre de la mascota debe tener al menos 2 caracteres")]
public string Nombre { get; set; }


[Required(ErrorMessage = "La especie es obligatoria")]
public string Especie { get; set; }


public string Raza { get; set; }


[Range(0, 25, ErrorMessage = "La edad debe estar entre 0 y 25 años")]
public int Edad { get; set; }


[Required(ErrorMessage = "El nombre del dueño es obligatorio")]
[MinLength(3, ErrorMessage = "El nombre del dueño debe tener al menos 3 caracteres")]
public string NombreDueño { get; set; }


[Required(ErrorMessage = "El teléfono del dueño es obligatorio")]
[RegularExpression(@"^\d{3}-\d{3}-\d{2}$", ErrorMessage = "El teléfono debe tener formato 851-842-94")]
public string TelefonoDueño { get; set; }


[DataType(DataType.Date)]
[Display(Name = "Fecha de ingreso")]
[CompareNotFutureDate(ErrorMessage = "La fecha de ingreso no puede ser futura")]
public DateTime FechaIngreso { get; set; }
    }
}
