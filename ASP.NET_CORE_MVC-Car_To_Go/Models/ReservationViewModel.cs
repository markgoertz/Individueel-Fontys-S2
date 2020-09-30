using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_MVC_Car_To_Go.Models
{
    public class ReservationViewModel : IReservation
    {
        [Key]
        public int Reservation_Number { get; set; }
        public string AspNetUsers_ID { get; set; }
        public int Car_ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Required")]
        public DateTime StartDate { get; set; }




        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Required")]
        public DateTime EndDate { get; set; }
    }
}
