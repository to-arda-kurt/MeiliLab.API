using System.ComponentModel.DataAnnotations.Schema;

namespace MeiliLab.API.Models.Database
{
    public class Address
    {
        public int Id { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public int CountryId { get; set; }
    }
}
