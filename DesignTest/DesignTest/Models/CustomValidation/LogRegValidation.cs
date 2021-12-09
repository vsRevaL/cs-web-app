using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignTest.Models.CustomValidation
{
    public class LogRegValidation : ValidationAttribute
    {
        public string GetRegErrorMessage() =>
            $"Felhasználónév már létezik.";

        public string GetLogErrorMessage() =>
            $"Bejelentkezés nem sikerült.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (AuthState.State == States.REG)
            {
                Useer user = (Useer)validationContext.ObjectInstance;

                if (user.Username != null && user.Username.Length >= 1 && user.Username.StartsWith('$'))
                {
                    return new ValidationResult(GetLogErrorMessage());
                }

                CarPoolDB db = new CarPoolDB();
                bool has = db.Useers.Any(x => x.Username == user.Username);
                return has? new ValidationResult(GetRegErrorMessage()) : ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(GetLogErrorMessage());
            }
        }
    }
}
