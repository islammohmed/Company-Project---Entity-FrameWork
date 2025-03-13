using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project.Entities
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]
        public string Manager { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<SupplyOrder> SupplyOrders { get; set; } = new List<SupplyOrder>();
        public ICollection<ReleaseOrder> ReleaseOrders { get; set; } = new List<ReleaseOrder>();
        public ICollection<Transfer> Transfers { get; set; }
    }
}
