using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B01.Invoice.Web.Entities
{
    public class ItemVAT
    {
        public Guid Id { get; set; }
        public Item Item { get; set; }
        public decimal VAT = 0.21M;
        public Guid ItemFK { get; set; }
    }
}
