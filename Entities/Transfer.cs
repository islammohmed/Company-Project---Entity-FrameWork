using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project.Entities
{
    public class Transfer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ItemId { get; set; }
        public Item Item { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required, ForeignKey("SourceWarehouse")]
        public int SourceWarehouseId { get; set; }
        public Warehouse SourceWarehouse { get; set; }

        [Required, ForeignKey("DestinationWarehouse")]
        public int DestinationWarehouseId { get; set; }
        public Warehouse DestinationWarehouse { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
