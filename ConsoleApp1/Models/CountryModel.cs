using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Models
{
    [ModelBinder(typeof(CustomModelBinderCountryDetails))]
    public class CountryModel
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        public int Id { get; set; }
    }
}
