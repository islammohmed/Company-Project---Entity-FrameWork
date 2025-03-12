using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project.Entities
{
    public class SupplyOrder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        [Required]
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public ICollection<SupplyOrderItem> SupplyOrderItems { get; set; } = new List<SupplyOrderItem>();
    }
}
