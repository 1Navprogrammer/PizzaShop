using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.ProtoTypes
{
    public class PizzaOrder // Prototype class to manage pizza orders
    {
        [Key] // Set PK for PizzaOrder
        public int PizzaOrderId { get; set; }
        [ForeignKey("Order")]
        public int OrderNumber { get; set; }// FK for Orders Table
        public Order Order { get; set; }
        [ForeignKey("Pizza")]
        public int PizzaCode { get; set; } // FK for Pizza Table
        public Pizza Pizza { get; set; }
        public int  Quantity { get; set; }// Quqntity of Pizza
    }
}
