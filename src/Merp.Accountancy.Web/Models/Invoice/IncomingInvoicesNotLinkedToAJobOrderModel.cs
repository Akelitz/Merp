﻿using System;
using System.Collections.Generic;

namespace Merp.Accountancy.Web.Models.Invoice
{
    public class IncomingInvoicesNotLinkedToAJobOrderModel
    {
        public int TotalNumberOfInvoices { get; set; }

        public IEnumerable<Invoice> Invoices { get; set; }

        public class Invoice
        {
            public Guid OriginalId { get; set; }

            public DateTime Date { get; set; }

            public string Number { get; set; }

            public string SupplierName { get; set; }

            public decimal Amount { get; set; }

            public string Type { get; set; }
        }
    }
}
