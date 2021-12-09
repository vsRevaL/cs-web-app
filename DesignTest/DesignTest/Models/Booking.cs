using System;
using System.Collections.Generic;

#nullable disable

namespace DesignTest.Models
{
    public partial class Booking
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int UserId { get; set; }

        public virtual Route Route { get; set; }
        public virtual Useer User { get; set; }
    }
}
