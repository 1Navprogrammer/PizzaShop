using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.ProtoTypes
{
    public class Order // Prototype for Order Class
    {
        [Key] // Use OrderNumber as PK in Database table
        public int OrderNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }// Order date set format to dd-m-yy
        public int CustId { get; set; } // FK for table Customer
        public Customer Customer { get; set; }
        public double TotalPrice { get; set; } // Total Price

        // Create list of PizzaOrder and initialize It
        public List<PizzaOrder> PizzaOrder { get; set; }
        // constructor
        public Order()
        {
            PizzaOrder = new List<PizzaOrder>();
        }
    }
}
