namespace MVC.Models
{
    public class Personnel
    {
        public int PersonnelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }

        //navigation
        public int RepresentationId { get; set; }
        public Representation Representation { get; set; }

    }
}
