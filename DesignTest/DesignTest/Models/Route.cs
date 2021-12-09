using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DesignTest.Models
{
    public partial class Route
    {
        public Route()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Indulási hely nem megfelelő")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "2 <= Indulási hely hossza <= 50")]
        public string FromCity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Érkezési hely nem megfelelő")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "2 <= Érkezési hely hossza <= 50")]
        public string ToCity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Megadott távolság nem megfelelő")]
        [Range(1, 20000, ErrorMessage = "1 <= Távolság <= 20000")]
        public int Km { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Időpont nem megfelelő")]
        [DataType(DataType.Date, ErrorMessage = "Időpont formátuma nem megfelelő")]
        public DateTime When { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ülőhelyek száma nem megfelelő")]
        [Range(1, 20, ErrorMessage = "1 <= Ülőhelyek száma <= 2")]
        public int Seats { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
