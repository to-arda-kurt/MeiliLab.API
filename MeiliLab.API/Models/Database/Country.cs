﻿namespace MeiliLab.API.Models.Database
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual IList<Property> Properties { get; set; }
    }
}
