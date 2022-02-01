using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    [Table("ProductInfo")]
    public class Product
    {
        public int Id { get; set; }

        [Column("ProductName")]
        [Required]
        public string Name { get; set; }

        public int Quantity { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }
    }
}