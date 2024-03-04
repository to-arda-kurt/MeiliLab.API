using MeiliLab.API.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeiliLab.API.Models.Database
{ 
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public int Beds { get; set; }
        public int Guests { get; set; }
        public double Rating { get; set; }
        public decimal PricePerNight { get; set; }
        public PropertyType PropertyType { get; set; }
        public int AddressId { get; set; }
        public int CountryId { get; set; }
       
    }
}