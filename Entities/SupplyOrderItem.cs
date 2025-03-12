using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project.Entities
{
    public class SupplyOrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("SupplyOrder")]
        public int SupplyOrderId { get; set; }
        [Required]

        public DateTime ProductionDate { get; set; }
        [Required]

        public DateTime ExpirationDate { get; set; }
        [Required]
        [ForeignKey("Item")]    
        public int ItemId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Item Item { get; set; }
        public SupplyOrder SupplyOrder { get; set; }
    }
}
