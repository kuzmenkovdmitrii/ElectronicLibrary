namespace ElLib.Common.Entity
{
    public class Address
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
    }
}
