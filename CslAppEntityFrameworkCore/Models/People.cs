namespace CslAppEntityFrameworkCore.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }
    }
}
