using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("The code used to indicate what type of documents is being transmitted, eg. Brokers’ catalogues or lot invoices.")]
    public enum TransmissionType
    {
        [Description("LotInvoices: Code: 0. Lot Invoices")]
        LotInvoices = 0,

        [Description("DeliveryOrders: Code: 1. Delivery Orders")]
        DeliveryOrders = 1,

        [Description("AuctionCatalogues: Code: 2. Auction Catalogues")]
        AuctionCatalogues = 2,

        [Description("PrivateCatalogues: Code: 3. Private Catalogues")]
        PrivateCatalogues = 3,

        [Description("GroupInvoices: Code: 4. Group Invoices")]
        GroupInvoices = 4,

        [Description("AuctionCatalogueUpdates: Code: 5. Auction Catalogue Updates")]
        AuctionCatalogueUpdates = 5,

        [Description("RequestPostSalePrintingOfPreSaleCertificates: Code: 6. Request Post-Sale Printing of Pre-Sale Certificates")]
        RequestPostSalePrintingOfPreSaleCertificates = 6,

        [Description("Statements: Code: 7. Statements")]
        Statements = 7,

        [Description("TestCertificateRequests: Code: 8. Test Certificate Requests")]
        TestCertificateRequests = 8,

        [Description("OrganisationDetails: Code: 11. Organisation Details")]
        OrganisationDetails = 11,

        [Description("LotPriceAndBuyer: Code: 13. Lot Price and Buyer")]
        LotPriceAndBuyer = 13,

        [Description("DeliveryOrderSummary: Code: 16. Delivery Order Summary")]
        DeliveryOrderSummary = 16,

        [Description("PaymentAdvice: Code: 17. Payment Advice")]
        PaymentAdvice = 17,

        [Description("TestCertificate: Code: 50. Test Certificate")]
        TestCertificate = 50,

        [Description("TestStatus: Code: 52. Test Status")]
        TestStatus = 52,

        [Description("TestRequestVerification: Code: 55. Test Request Verification")]
        TestRequestVerification = 55,

        [Description("DarkAndMedullatedFibreRiskVerification: Code: 56. Dark and Medullated Fibre Risk Verification")]
        DarkAndMedullatedFibreRiskVerification = 56,

        [Description("TestCertificateUpdate: Code: 60. Test Certificate Update")]
        TestCertificateUpdate = 60,

        [Description("PaymentConfirmationFile: Code: 64. Payment Confirmation File")]
        PaymentConfirmationFile = 64,

        [Description("TextFile: Code:98. Text File")]
        TextFile = 98,

        [Description("PasswordReplacement: Code: 99. Password Replacement")]
        PasswordReplacement = 99
    }    
}
