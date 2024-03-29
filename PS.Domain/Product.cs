﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Product: Concept
    {
        public static int Compteur { get; set; }
        
        public Product()
        {
            Compteur++;
        }
        public Product(DateTime DateProd, string description, string name, double price, int quantity, int productId)
        {
            this.DateProd = DateProd;
            Description = description;
            Name = name;
            Price = price;
            Quantity = quantity;
            ProductId = productId;
            Compteur++;
        }

        public DateTime DateProd { get; set; }
        //attribut
        public  string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int ProductId { set; get; }

        public Category Category { get; set; }

        public IList<Provider> Providers { get; set; }

        public virtual void GetMyType()
        {
            Console.WriteLine("Je suis un produit");
        }

        public override string ToString()
        {
            return ProductId + " " + Name 
                + " " + Price + " " + DateProd + " " + Quantity;
                ;
        }

        public override void GetDetails()
        {
            Console.WriteLine(ToString());
        }
    }

    
}
