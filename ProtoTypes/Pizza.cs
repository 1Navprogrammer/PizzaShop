using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.ProtoTypes
{

    public class Pizza // Pizza Prototype Class
     {
        [Key] // PizzaCode will be used as PK
        public int PizzaCode { get; set; }
        public string PizzaName { get; set; }  // Pizza Name
        public string PizzaSize { get; set; } // Size of pizza
        public double Price { get; set; }  // Pizza Price
        public bool IsSpicy { get; set; }  // Spicy or Not

        public List<PizzaOrder> PizzaOrder { get; set; }
        public Pizza()
        {
            PizzaOrder = new List<PizzaOrder>(); // Initalize list of pizzaorder
        }

    }
}
