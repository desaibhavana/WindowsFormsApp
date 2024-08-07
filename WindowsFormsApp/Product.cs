using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    [Serializable]  //attribute , anotation,, decorator
    internal class Product
    {
        //Auto implemented Properties

        public int ProdId { get; set; }
        public string  ProductName { get; set; }      
        public double Price { get; set; }

        public Product()
        {
            Price = 1000;
        }
    }
}
