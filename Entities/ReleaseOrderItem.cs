using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project.Entities
{
    public class ReleaseOrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required, ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; } 

        [Required, ForeignKey("ReleaseOrder")]
        public int ReleaseOrderId { get; set; }
        public ReleaseOrder ReleaseOrder { get; set; } 
    }
}
