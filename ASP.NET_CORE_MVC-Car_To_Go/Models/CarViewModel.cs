﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Entities;
using System.ComponentModel.DataAnnotations;

namespace Car_To_Go.Models
{
    public class CarViewModel : ICar
    {
        [Key]
        public int ID { get; set; }


        [Display(Name = "Brandname")]
        [Required(ErrorMessage = "Required")]
        public string Brandname { get; set; }

        [Display(Name = "Modelname")]
        [Required(ErrorMessage = "Required")]
        public string Modelname { get; set; }

        [Display(Name = "Transmission")]
        [Required(ErrorMessage = "Required")]
        public string Transmission { get; set; }


        [Display(Name = "Enginepower")]
        [Required(ErrorMessage = "Required")]
        [Range(50, 1000, ErrorMessage = "The car must have a engine power between 50 and 1000 HP!")]
        public int Enginepower { get; set; }

       
        [Display(Name = "Weight")]
        [Required(ErrorMessage = "This field is required!")]
        public int Weight { get; set; }


        [Display(Name = "Acceleration")]
        [Required(ErrorMessage ="This field is required!")]
        [Range(1, 15, ErrorMessage = "The car need to have an accelaration between 1 and 15 seconds!")]
        public double Acceleration { get; set; }


        [Display(Name = "Cargospace")]
        [Required(ErrorMessage = "Required")]
        public int Cargospace { get; set; }


        [Display(Name = "Seat")]
        [Required(ErrorMessage = "Required")]
        public int Seat { get; set; }


        [Display(Name = "Rentalprice")]
        [Required(ErrorMessage = "Required")]
        public double RentalPrice { get; set; }


        [Display(Name = "Fueltype")]
        [Required(ErrorMessage = "Required")]
        public string Fueltype { get; set; }


        [Required(ErrorMessage = "This field is required!")]
        public string ImageLink { get; set; }

    }
}
