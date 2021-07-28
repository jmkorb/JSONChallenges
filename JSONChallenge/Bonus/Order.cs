using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Bonus
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Address ShippingAddress { get; set; }
    }
    public class Item 
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
    public class Order
    {
        public string OrderID { get; set; }

        public Customer Customer { get; set; }
        public List<Item> LineItems { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
