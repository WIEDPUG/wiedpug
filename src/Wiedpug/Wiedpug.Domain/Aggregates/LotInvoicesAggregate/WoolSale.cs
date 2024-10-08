﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.LotInvoicesAggregate
{
    public class WoolSale
    {
        [Required]
        public required WoolSaleHeaderLot WoolSaleHeaderLot { get; set; }

        [Required]
        public required List<LotInvoiceDetail> LotInvoiceDetails { get; set; }
    }
}
