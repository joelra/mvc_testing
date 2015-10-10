using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        public List<Product> Products { get; set; }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<Product>)Products).GetEnumerator();
        }

        IEnumerator<Product> IEnumerable<Product>.GetEnumerator()
        {
            return Products.GetEnumerator();
        }
    }
}