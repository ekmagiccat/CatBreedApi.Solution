using System.ComponentModel.DataAnnotations;

namespace CatBreed.Models {
    public class Cat
    {
        public int CatId { get; set; }
        public string BreedName { get; set; }
        public string Fur { get; set; }
        public string Temperament { get; set; }
        public int AvgKittenPrice { get; set; }
        public int UsPopularity { get; set; }
    }
}