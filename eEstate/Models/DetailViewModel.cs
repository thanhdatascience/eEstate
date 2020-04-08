using Microsoft.AspNetCore.Http;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eEstate.Models
{
    public class DetailViewModel
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public decimal Price { get; set; }
        public decimal Area { get; set; }
        public DateTime PostingDate { get; set; }
        public string Juridical { get; set; } // Pháp lí
        public string Direction { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoPath { get; set; }
    }
}
