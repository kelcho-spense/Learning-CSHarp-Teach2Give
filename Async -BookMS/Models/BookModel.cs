using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async__BookMS.Models
{
    public class BookModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string DatePublished { get; set; }
    }
}
