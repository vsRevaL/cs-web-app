using DesignTest.Models.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DesignTest.Models
{
    public partial class Useer
    {
        public Useer()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Felhasználónév nem megfelelő")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "1 <= Felhasználónév hossza <= 25")]
        [LogRegValidation]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Jelszó nem megfelelő")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "1 <= Jelszó hossza <= 25")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Jelszó nem megfelelő")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "<= 1 Jelszó hossza <= 25")]

        [NotMapped()]
        [Compare("Password", ErrorMessage = "A jelszavak nem egyeznek")]
        public string ConfirmPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Név nem megfelelő")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "1 <= Névhossza <= 30")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Lakcím nem megfelelő")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "4 <= Lakcím hossza <= 25")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email cím nem megfelelő")]
        [EmailAddress( ErrorMessage = "Helytelen Email cím formátum")]
        [StringLength(25, ErrorMessage = "3 <= Email cím hossza <= 25")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Telefonszám nem megfelelő")]
        [Phone(ErrorMessage = "Helytelen telefonszám formátum")]
        [StringLength(11, MinimumLength = 3, ErrorMessage = "3 <= Telefonszám hossza <= 11.")]
        public string Phone { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
