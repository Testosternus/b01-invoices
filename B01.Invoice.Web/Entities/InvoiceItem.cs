using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B01.Invoice.Web.Entities
{
    public class InvoiceItem
    {
        public Guid BillId { get; set; }
        public Guid ItemId { get; set; }
        public Bill Bill { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
