using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B01.Invoice.Web.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
        public ItemVAT VAT { get; private set; }
    }
}