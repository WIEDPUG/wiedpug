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
                    DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
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
                                            Season = new Season{SeasonValue= 23},
                                            SaleIdentity = new SaleIdentity
                                            {
                                                SellingCentreType = "M",
                                                SaleNumber = 18
                                            },
                                            CentreStorage =new Centre
                                            {
                                                CountryCode = CountryCode.AU,
                                                CentreCode = CentreCodeAustralia.A
                                            },
                                            StorageOrganisation = new Organisation
                                            {
                                                OrganisationCode = "ABT",
                                            },
                                            LotIdentityOrGroupNumber = "552467",
                                            NumberOfBales = new NumberOfBales{BalesCount=30 },
                                            Gross = new Weight{
                                                Value = 1530.00,
                                                WeightCode = WeightCode.KG
                                            },
                                            Tare = new Weight{
                                                Value = 30.00,
                                                WeightCode = WeightCode.KG
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
                                                    BaleDescription = new BaleDescription{ Description="bale description"},
                                                    AreaOfOrigin = "MELB"
                                                },
                                                BaleDetails = new List<BaleDetail>
                                                {
                                                    new BaleDetail
                                                    {
                                                        BaleDetailType=BaleDetailType.Renumbers,
                                                        BaleNumber = "12345",
                                                        Gross=new Weight { Value = 1233.00, WeightCode = WeightCode.KG },
                                                        Tare=new Weight { Value = 23.00, WeightCode = WeightCode.KG }
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

    public class RequestForDeliveryOrdersAndShippingInstructionsExample : IExamplesProvider<List<RequestForData>>
    {
        public List<RequestForData> GetExamples()
        {
            return new List<RequestForData>()
            {
                new RequestForData {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                RequestForDataType = new UseNetworkDateTimeRequestForDataType
                {
                    IsUsingNetworkDateTime = true
                }
                }
            };
        }
    }

    public class RequestForDeliveryOrdersAndShippingInstructions200Example : IExamplesProvider<ApiResult<List<DeliveryOrdersAndShippingInstruction>>>
    {
        public ApiResult<List<DeliveryOrdersAndShippingInstruction>> GetExamples()
        {
            return new ApiResult<List<DeliveryOrdersAndShippingInstruction>>()
            {
                
                ApiMessages = [],
                Data = new List<DeliveryOrdersAndShippingInstruction>
                {
                        new DeliveryOrdersAndShippingInstruction
                        {
                                                TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                            SoftwareVersion =  1082
                        },
                        Abn = 72001967184
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
                                            Season = new Season{SeasonValue= 23},
                                            SaleIdentity = new SaleIdentity
                                            {
                                                SellingCentreType = "M",
                                                SaleNumber = 18
                                            },
                                            CentreStorage = new Centre {
                                                CountryCode = CountryCode.AU,
                                                CentreCode = CentreCodeAustralia.A
                                            },
                                            StorageOrganisation = new Organisation
                                            {
                                                 OrganisationCode = "MBC",
                                            },
                                            LotIdentityOrGroupNumber = "552467",
                                            NumberOfBales = new NumberOfBales{BalesCount=30 },
                                            Gross = new Weight{
                                                Value = 1520.00,
                                                WeightCode = WeightCode.KG
                                            },
                                            Tare = new Weight{
                                                Value = 30.00,
                                                WeightCode = WeightCode.KG
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
                                                    BaleDescription = new BaleDescription{ Description="bale description"},
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
                                                WeightCode = WeightCode.KG
                                            },
                                                        Tare=new Weight { Value = 23.00, WeightCode = WeightCode.KG }
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
