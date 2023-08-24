namespace MVC.Models
{
    public class Representation
    {
        public int RepresentationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }

        //navigation

        public ICollection<Personnel> Personnels { get; set; }

        public int CiryId { get; set; }
        public City City { get; set;}

    }
}
