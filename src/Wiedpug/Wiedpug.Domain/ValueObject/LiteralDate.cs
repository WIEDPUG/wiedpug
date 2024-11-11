using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    /// <summary>
    /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).
    /// 
    /// dateOfCreditNote: Date the Credit note was issued
    /// 
    /// dateOfOriginalInvoice: Date of the original invoice
    /// 
    /// dateIssue: The date the certificate was issued.
    /// 
    /// dateLastUpdated: The day the item was last amended.
    /// 
    /// statementDate: The period ending date of the statement.
    /// 
    /// statementPaymentDate: The date the payment was made.
    /// 
    /// datePaymentMade: Required date field for the date payment was made.
    /// 
    /// saleDate: The date on which the wool was sold.
    /// 
    /// coreTestSamplingDate: For Fibre Diameter Histogram Header and Test Request Verification this is the date core test was sampled or date combination/OML was requested. For the Lot Header this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.
    /// 
    /// itemDate: The date the cost of the item was incurred.
    /// 
    /// </summary>  
    public class LiteralDate
    {
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? Date { get; set; }
    }
}
