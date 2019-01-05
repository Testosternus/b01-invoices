using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B01.Invoice.Web.Entities
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTimeOffset IssuedDate { get; set; }
        public ICollection<InvoiceItem> Items { get; set; }
    }
}
