using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ProductMS
{
    public class ProductModels
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
        public string Description { get; set; } = string.Empty;       
    }
   
}
