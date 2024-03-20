﻿using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordType
    {        
        TransmissionHeader,
        ExclusionInclusionList,
        FinalReceiverList,
        WoolSaleHeaderLots,
        WoolSaleHeaderExtension,
        WoolSaleHeaderNonAuction,
        WoolSaleHeaderGroups,
        LotPriceandBuyerDetails,
        SaleStatus,
        LotHeaderAppraisaldata,
        LotHeaderExtension,
        LotHeaderPricingData,
        LotHeaderAWEXData,
        GroupHeader,
        GroupHeaderExtension,
        LotInvoiceHeader,
        LotInvoiceExtension,
        LotHeader,
        LotDetails,
        LotHeaderVendorDeclaration,
        LotPaymentDetail,
        FibreDiameterHistogramHeader,
        FibreDiameterHistogramDetail,
        Name,
        Address,
        CentreDetails,
        ConsignmentHeader,
        ConsignmentExtension1,
        ConsignmentExtension2,
        CountermarkHeadmark,
        DeliveryOrderDetail,
        DeliveryOrderDetailExtension1,
        DeliveryOrderDetailExtension2,
        Comment,
        TestDataHeader,
        ColourDetails,
        DichloromethaneTestDetails,
        ScouredYieldExtension,
        PremiumTestDetails,
        SubjectiveInterlotDetails,
        CombinationDetails,
        LengthandStrengthCombinationDetails,
        LengthandStrengthDetails,
        OMLCertificateDetails,
        OMIDetails,
        CoreTestDetails,
        GuidanceReportDetails,
        LengthAfterCardingTestDetails,
        ConditioningTestDetails,
        ScouredTestDetails,
        PostsaleCoreTestDetails,
        ColourCombinationDetails,
        AdjustmentNoteDetails,
        TestStatusDetail,
        RequestforData,
        ContractLimitRequirements,
        CoreTestRequestVerification,
        DarkandMedullatedFibreRiskDetails,
        RequestPostSalePrintingofPreSaleCertificate,
        CertificateRequest,
        CertificateRequestcont,
        TestCertificateUpdateDetail,
        PaymentDetail,
        PaymentHeader,
        StatementDetail,
        StatementHeader,
        StatementTrailer,
        MiscellaneousCharge,
        PaymentSummary,
        OtherDetails,
        CatalogueLotDesc,
        InterlotComponentBaleHeader,
        BaleHeader,
        PropertyIdentificationCodes,
        BaleDetailGreasyProc,
        BaleDetailRenumbers,
        BaleDetailTripacks,
        BaleIdentification,
        TransmissionResponse,
        TransmissionTotals
    }
}