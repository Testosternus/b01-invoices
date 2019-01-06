using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B01.Invoice.Web.Entities
{
    public class Counter
    {
        private long value = 0;
        public long InvoiceNo
        {
            get
            {
                ++value;
                return value;
            }
            private set { }
        }
    }
}
