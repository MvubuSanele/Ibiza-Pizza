using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ibiza_Pizza.Models
{
    public class Ibiza
    {
        public enum PizzaSize
        {
            ExtraLarge,
                Large,
                Medium,
                Small,
        }
        [Required(ErrorMessage = "Please Enter Tendered Cash")]
        [DisplayName("Tendered Cash")]
        public double Cash { get; set; }
        
        [DisplayName("Here is your Total")]
        public double Total { get; set; }
        
        [DisplayName("Here is your Change")]
        public double Change { get; set; }

        [Required(ErrorMessage = "Please Enter Type of Pizzas")]
        [DisplayName("Type of Pizza")]
        public string Pizza_type { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity of Pizzas")]
        [DisplayName("Quantity")]
        public int Qty { get; set; }

        [DisplayName("Do you want something to drink?")]
        public bool Drink { get; set; }

        [Required(ErrorMessage ="Please enter Customer name Bitch!!!")]
        [DisplayName("Please enter Customer Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only please")]
        public string name { get; set; }
        public PizzaSize Bro { get; set; }

        public double calcPizza()
        {
            double Sip = 0;
                if(Drink== true)
            {
                Sip = 20;
            }
            return Sip;
        }

        public double calcSize()//Dropdownlist
        {
            double pizza = 0;
            if (Bro == PizzaSize.ExtraLarge)
            {
                pizza = 100;
            }
            else if (Bro == PizzaSize.Large)
            {
                pizza = 75.50;
            }
            else if (Bro == PizzaSize.Medium)
            {
                pizza = 50.50;
            }
            else if (Bro == PizzaSize.Small)
            {
                pizza = 35.99;
            }
            return pizza;
        }

        public double calPizza_type()
        {
            double type = 0;
            if (Pizza_type == "Veg")
            {
                type = 11.99;
            }
            if (Pizza_type == "Chicken")
            {
                type = 14.99;
            }
            return type;
        }

        public double calcSub()
        {
            return (calcSize() + calPizza_type()) * Qty;
        }
        public double calcTotal()
        {
            return calcPizza() + calcSub();
        }

        public double calcChange()//Method to calculate change
        {
            return Cash - calcTotal();
        }
    }
}