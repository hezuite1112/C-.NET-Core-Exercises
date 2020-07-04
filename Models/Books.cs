using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Author { get; set; }
        
        public DateTime Year_of_realesae { get; set; }

        public int Sites { get; set; }

        public int Quantity { get; set; }

    }
}
