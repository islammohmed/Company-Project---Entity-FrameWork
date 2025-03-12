using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project.Entities
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]

        public string Name { get; set; }

        public string Fax { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public string Site { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }

        public ICollection<SupplyOrder> SupplyOrders { get; set; }

    }
}
