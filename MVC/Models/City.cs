namespace MVC.Models
{
    public class City
    {
        public int CityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        //navigation

        public ICollection<Representation> Representations { get; set; }
    }
}
