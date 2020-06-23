using System;
using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value < DateTime.Now)
                return new ValidationResult("Date and time must be in the future!!!");
            return ValidationResult.Success;
        }
    }
}