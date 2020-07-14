using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_CRUD_ASP.NET_CORE_3._1.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
