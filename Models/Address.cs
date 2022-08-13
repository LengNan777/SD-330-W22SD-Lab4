namespace Lab4.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }

        public int StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
