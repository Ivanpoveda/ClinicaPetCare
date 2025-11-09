using System;
using System.ComponentModel.DataAnnotations;

public class CompareNotFutureDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null) return true; // [Required] se encarga si es obligatorio
        if (value is DateTime dt)
        {
            return dt.Date <= DateTime.Now.Date;
        }
        return false;
    }
}
