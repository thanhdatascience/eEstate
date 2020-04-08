using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eEstate.Models
{
    public class TouristAttractionViewModel
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
    }
    public class SearchInputModel  
    {  
        public double Latitude { get; set; }  
        public double Longitude { get; set; }  
    }  
  
    public class IndexPageViewModel  
    {  
        public SearchInputModel SearchInput { get; set; }  
        public List<TouristAttractionViewModel> TouristAttractions { get; set; }  
    }  
}
