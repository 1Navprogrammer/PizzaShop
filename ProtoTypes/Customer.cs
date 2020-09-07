using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.ProtoTypes
{
    public class Customer// Prototype for customer class
    {
        [Key] // Use CustId as PK in Database
        public int CustId { get; set; }
        public string FirstName { get; set; }// First name of customer
        public string LastName { get; set; } // Last Name of Customer
        public string Address { get; set; } // Address of Customer

        
        public List<Order> Order { get; set; } // Creat List of Order
        public Customer()
        {
            Order = new List<Order>(); // Initialize Order List
        }

    }
}
