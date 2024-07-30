using System.ComponentModel.DataAnnotations;
namespace solidReference.Models{
    public class City{
        [Key]
        public int Id { get; set;}

        public string cityName { get; set;}
    }
}