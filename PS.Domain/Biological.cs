using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public sealed class Biological: Product
    {
        public string Herbs { get; set; }
        public sealed override void GetMyType()
        {
            Console.WriteLine("Je suis un produit biological");
        }
    }
}
