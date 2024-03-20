using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("The code used to indicate what type of documents is being transmitted, eg. Brokers’ catalogues or lot invoices.")]
    public enum TransmissionType
    {
        [Description("0: Lot Invoices")]
        LotInvoices = 0,

        [Description("1: Delivery Orders")]
        DeliveryOrders = 1,

        [Description("2: Auction Catalogues")]
        AuctionCatalogues = 2,

        [Description("3: Private Catalogues")]
        PrivateCatalogues = 3,

        [Description("4: Group Invoices")]
        GroupInvoices = 4,

        [Description("5: Auction Catalogue Updates")]
        AuctionCatalogueUpdates = 5,

        [Description("6: Request Post-Sale Printing of Pre-Sale Certificates")]
        RequestPostSalePrintingOfPreSaleCertificates = 6,

        [Description("7: Statements")]
        Statements = 7,

        [Description("8: Test Certificate Requests")]
        TestCertificateRequests = 8,

        [Description("11: Organisation Details")]
        OrganisationDetails = 11,

        [Description("13: Lot Price and Buyer")]
        LotPriceAndBuyer = 13,

        [Description("16: Delivery Order Summary")]
        DeliveryOrderSummary = 16,

        [Description("17: Payment Advice")]
        PaymentAdvice = 17,

        [Description("50: Test Certificate")]
        TestCertificate = 50,

        [Description("52: Test Status")]
        TestStatus = 52,

        [Description("55: Test Request Verification")]
        TestRequestVerification = 55,

        [Description("56: Dark and Medullated Fibre Risk Verification")]
        DarkAndMedullatedFibreRiskVerification = 56,

        [Description("60: Test Certificate Update")]
        TestCertificateUpdate = 60,

        [Description("64: Payment Confirmation File")]
        PaymentConfirmationFile = 64,

        [Description("98: Text File")]
        TextFile = 98,

        [Description("99: Password Replacement")]
        PasswordReplacement = 99
    }
}
