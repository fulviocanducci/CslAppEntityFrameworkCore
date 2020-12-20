namespace CslAppEntityFrameworkCore.Models
{
    public class Address
    {
        public int PeopleId { get; set; }
        public virtual People People { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
