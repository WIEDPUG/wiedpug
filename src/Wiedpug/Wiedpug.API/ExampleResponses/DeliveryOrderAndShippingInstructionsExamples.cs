using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Controllers.V0;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.DeliveryOrdersAndShippingInstructionsAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreateDeliveryOrderAndShippingInstructionsExample : IExamplesProvider<List<DeliveryOrdersAndShippingInstruction>>
    {
        public List<DeliveryOrdersAndShippingInstruction> GetExamples()
        {
            return new List<DeliveryOrdersAndShippingInstruction>
            {
                    new DeliveryOrdersAndShippingInstruction
                    {
                                        TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                                                OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",
                    },
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                TransferConfig = new TransferConfig
                 {
                     TransferType = TransferType.Unrestrict
                },
                Consignments = new List<Consignment>
                {
                    new Consignment
                    {
                        ConsignmentHeader = new ConsignmentHeader
                        {
                            ConsignmentReference = "1256745909",
                            Shipper = new Organisation
                            {
                                                        OrganisationCode = "BTA",
                            }
                        },
                        CountermarkHeadmarks = new List<CountermarkHeadmark>
                        {
                            new CountermarkHeadmark
                            {
                                CountermarkHeadmarkLine1="1234567789",
                                CountermarkHeadmarkLine2="1234098765",
                            }
                        }
                        ,DeliveryOrders = new List<DeliveryOrder>{
                            new DeliveryOrder
                            {
                                DeliveryOrderDetail = new DeliveryOrderDetail
                                {
                                    DeliveryOrderType=DeliveryOrderType.O,
                                    DeliveryOrderNumber="4567891209",
                                    ReleasingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "AWS",
                                    },
                                    Carrier = new Organisation
                                    {
                                                                OrganisationCode = "BTW",
                                    },
                                    AreRenumbersApplied = false,
                                    AreGrossWeightsApplied = false,
                                    AreNetWeightsApplied = false
                                },
                                DeliveryOrderLots = new List<DeliveryOrderLot>
                                {
                                    new DeliveryOrderLot
                                    {
                                        DeliveryOrderLotHeader = new DeliveryOrderLotHeader
                                        {
                                            InvoicingOrganisation = new Organisation
                                            {
                                                OrganisationCode = "AWT",
                                            },
                                            SellingOrganisation = new Organisation
                                            {
                                                                        OrganisationCode = "TTM",
                                            },
                                            Season = 23,
                                            SaleIdentity = "N23",
                                            CentreStorage =new Centre
                                            {
                                                Country = CountryCode.AU,
                                                CentreCode = CentreCodeAustralia.A
                                            },
                                            StorageOrganisation = new Organisation
                                            {
                                                OrganisationCode = "ABT",
                                            },
                                            LotIdentityOrGroupName = new LotIdentityOrGroupName
                                            {
                                                LotIdentity = "552467"
                                            },
                                            Bales = 30,
                                            Gross = new Weight{
                                                Value = 1530.00,
                                                Unit = WeightUnit.Kilograms
                                            },
                                            Tare = new Weight{
                                                Value = 30.00,
                                                Unit = WeightUnit.Kilograms
                                            },
                                            TotalBalesInLot = 30,
                                            PackTypeOriginal = PackType._1,
                                            PackTypePreferred = PackType._2,
                                            WoolState = WoolState._3,
                                            PackMaterial = PackMaterial.K

                                        },
                                        CountermarkHeadmarks = new List<CountermarkHeadmark>
                                        {
                                            new CountermarkHeadmark
                                            {
                                                CountermarkHeadmarkLine1="1234567789",
                                                CountermarkHeadmarkLine2="1234098765",
                                            }
                                        },
                                        Bales = new List<Bale>
                                        {
                                            new Bale
                                            {
                                                BaleHeader = new BaleHeader
                                                {
                                                    Brand = "ABCD",
                                                    BaleDescription = "bale description",
                                                    AreaOfOrigin = "MELB"
                                                },
                                                BaleDetails = new List<BaleDetail>
                                                {
                                                    new BaleDetail
                                                    {
                                                        BaleDetailType=BaleDetailType.Renumbers,
                                                        BaleNumber = "12345",
                                                        Gross=new Weight { Value = 1233.00, Unit = WeightUnit.Kilograms },
                                                        Tare=new Weight { Value = 23.00, Unit = WeightUnit.Kilograms }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                }
            };
        }
    }

    public class RequestForDeliveryOrdersAndShippingInstructionsExample : IExamplesProvider<RequestForDataRework>
    {
        public RequestForDataRework GetExamples()
        {
            return new RequestForDataRework()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATW",
                    },
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                SaleIdentity = "F18",
                OrganisationRequested = new Organisation { OrganisationCode = "ANF", },
                SaleDateRequested = "2023-10-31",
                IsUsingNetworkDateTime = false,
                RequestType = Domain.Enums.RequestTypeForData.BroadcastDataRequest,
                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                Season = 23
            };
        }
    }

    public class RequestForDeliveryOrdersAndShippingInstructions200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                Message = null,
                Data = new List<DeliveryOrdersAndShippingInstruction>
                {
                        new DeliveryOrdersAndShippingInstruction
                        {
                                                TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                                                    OrganisationCode = "ABC",
                        },
                        CurrentReceiver = new Organisation
                        {
                                                    OrganisationCode = "ATW",
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Talman,
                            Version = 1082
                        },
                        ABN = "72001967184"
                    },
                    Consignments = new List<Consignment>
                {
                    new Consignment
                    {
                        ConsignmentHeader = new ConsignmentHeader
                        {
                            ConsignmentReference = "1256745909",
                            Shipper = new Organisation
                            {
                                                        OrganisationCode = "BTA",
                            }
                        },
                        CountermarkHeadmarks = new List<CountermarkHeadmark>
                        {
                            new CountermarkHeadmark
                            {
                                CountermarkHeadmarkLine1="1234567789",
                                CountermarkHeadmarkLine2="1234098765",
                            }
                        }
                        ,DeliveryOrders = new List<DeliveryOrder>{
                            new DeliveryOrder
                            {
                                DeliveryOrderDetail = new DeliveryOrderDetail
                                {
                                    DeliveryOrderType=DeliveryOrderType.O,
                                    DeliveryOrderNumber="4567891209",
                                    ReleasingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "AWS",
                                    },
                                    Carrier = new Organisation
                                    {
                                                                OrganisationCode = "BTW",
                                    },
                                    AreRenumbersApplied = false,
                                    AreGrossWeightsApplied = false,
                                    AreNetWeightsApplied = false
                                },
                                DeliveryOrderLots = new List<DeliveryOrderLot>
                                {
                                    new DeliveryOrderLot
                                    {
                                        DeliveryOrderLotHeader = new DeliveryOrderLotHeader
                                        {
                                            InvoicingOrganisation = new Organisation
                                            {
                                                OrganisationCode = "ATX",
                                            },
                                            SellingOrganisation = new Organisation
                                            {
                                                                        OrganisationCode = "TTM",
                                            },
                                            Season = 23,
                                            SaleIdentity = "N23",
                                            CentreStorage = new Centre {
                                                Country = CountryCode.AU,
                                                CentreCode = CentreCodeAustralia.A
                                            },
                                            StorageOrganisation = new Organisation
                                            {
                                                 OrganisationCode = "MBC",
                                            },
                                            LotIdentityOrGroupName = new LotIdentityOrGroupName
                                            {
                                                LotIdentity = "552467"
                                            },
                                            Bales = 30,
                                            Gross = new Weight{
                                                Value = 1520.00,
                                                Unit = WeightUnit.Kilograms
                                            },
                                            Tare = new Weight{
                                                Value = 30.00,
                                                Unit = WeightUnit.Kilograms
                                            },
                                            TotalBalesInLot = 30,
                                            PackTypeOriginal = PackType._1,
                                            PackTypePreferred = PackType._2,
                                            WoolState = WoolState._3,
                                            PackMaterial = PackMaterial.K

                                        },
                                        CountermarkHeadmarks = new List<CountermarkHeadmark>
                                        {
                                            new CountermarkHeadmark
                                            {
                                                CountermarkHeadmarkLine1="1234567789",
                                                CountermarkHeadmarkLine2="1234098765",
                                            }
                                        },
                                        Bales = new List<Bale>
                                        {
                                            new Bale
                                            {
                                                BaleHeader = new BaleHeader
                                                {
                                                    Brand = "ABCD",
                                                    BaleDescription = "bale description",
                                                    AreaOfOrigin = "MELB"
                                                },
                                                BaleDetails = new List<BaleDetail>
                                                {
                                                    new BaleDetail
                                                    {
                                                        BaleDetailType=BaleDetailType.Renumbers,
                                                        BaleNumber = "12345",
                                                        Gross=new Weight{
                                                Value = 1233.00,
                                                Unit = WeightUnit.Kilograms
                                            },
                                                        Tare=new Weight { Value = 23.00, Unit = WeightUnit.Kilograms }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                    }
                }
            };
        }
    }
}
