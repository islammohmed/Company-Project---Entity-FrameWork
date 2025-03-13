using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project.Entities
{
    public class ReleaseOrder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string OrderNumber { get; set; }
        [Required]
        public int TotalQuantity { get; set; }
        [Required]
        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<ReleaseOrderItem> ReleaseOrderItems { get; set; } = new List<ReleaseOrderItem>();
    }
}
