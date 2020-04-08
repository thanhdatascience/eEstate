using System;
using System.IO;
using System.Linq;
using eEstate.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Geometries;
using static eEstate.SpatialSample;

namespace SpatialSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly SpatialDbContext _spatialDbContext;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(SpatialDbContext spatialDbContext,
                                IHostingEnvironment hostingEnvironment)
        {
            this._spatialDbContext = spatialDbContext;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search([FromForm] IndexPageViewModel indexModel)
        {
            var indexViewModel = new IndexPageViewModel
            {
                SearchInput = indexModel.SearchInput
            };

            // Convert the input latitude and longitude to a Point  
            var location = new Point(indexModel.SearchInput.Latitude, indexModel.SearchInput.Longitude) { SRID = 4326 };

            // Fetch the tourist attractions and their  
            // distances from the input location   
            // using spatial queries.  
            var touristAttractions = _spatialDbContext
                .TouristAttractions
                .Select(t => new 
                { 
                    Place = t, Distance = t.Location.Distance(location),
                })
                .ToList();

            // Ordering the result in the ascending order of distance  
            indexViewModel.TouristAttractions = touristAttractions
                .OrderBy(x => x.Distance)
                .Select(t => new TouristAttractionViewModel
                {
                    Id = t.Place.Id,
                    Distance = Math.Round(t.Distance, 6),
                    Latitude = t.Place.Location.X,
                    Longitude = t.Place.Location.Y,
                    Name = t.Place.Name,
                    Price = t.Place.Price,
                    Area = t.Place.Area,
                    PostingDate = t.Place.PostingDate,
                    Juridical = t.Place.Juridical,
                    Direction = t.Place.Direction
                }).ToList();

            return View("Index", indexViewModel);
        }

        public IActionResult Detail(int Id, DetailViewModel model)
        {
            string uniqueFileName = null;
            if(model.Photo != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                _spatialDbContext.TouristAttractions.Find(Id).PhotoPath = filePath;
                _spatialDbContext.SaveChanges();
            }

            var touristAttractions = _spatialDbContext.TouristAttractions.FirstOrDefault(i => i.Id == Id);
            var detailViewModel = new DetailViewModel()
            {
                Id = touristAttractions.Id,
                Name = touristAttractions.Name,
                Price = touristAttractions.Price,
                Area = touristAttractions.Area,
                PostingDate = touristAttractions.PostingDate,
                Juridical = touristAttractions.Juridical,
                Direction = touristAttractions.Direction,
                PhotoPath = Path.GetFileName(touristAttractions.PhotoPath)
            };
            
            return View("Detail", detailViewModel);

        }
    }
}