using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace eEstate.Entities
{
    public class TouristAttraction
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "geometry")]
        public Point Location { get; set; }
        public decimal Price { get; set; }
        public decimal Area { get; set; }
        public DateTime PostingDate { get; set; }
        public string Juridical { get; set; } // Pháp lí
        public string Direction { get; set; }
        public string PhotoPath { get; set; }
    }
}
