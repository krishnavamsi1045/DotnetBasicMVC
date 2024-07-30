
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace solidReference.Models{
    
    public class student{
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public long phone { get; set; }

    [ForeignKey("City")]
        public int city {get;set;}
[ForeignKey("Country")]
        public int country {get;set;}


    //Navigation Property makes your work more easier when writing entity framework queries
        public Country Country{get; set;}

        public City City{get;set;}
    }


}