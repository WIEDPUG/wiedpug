﻿using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.TestStatusAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class TestStatusRequestExample : IExamplesProvider<List<TestStatus>>
    {
        public List<TestStatus> GetExamples()
        {
            return new List<TestStatus>()
            {
                new TestStatus {
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
                        SoftwareVersion =  1082
                    },
                    Abn = "72001967184"
                },
                TestStatusDetails = new List<TestStatusDetail>
                {
                    new TestStatusDetail
                    {
                        CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = 1234567,
                        },
                        ClientCode = 19944,
                        ChargeCode = 5112,
                        LsSampleId = new LsSampleId{
                            Prefix = "F",
                            Number = 88568,
                            CheckDigit = 8
                        },
                        CoreSampleReceived = "240423",
                        LsSampleReceived = "240424",
                        TrvMatched = "240424",
                        LsRetuftRequired = LsRetuftRequired.Required
                    },
                    new TestStatusDetail {
                        CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = 1234567,
                        },
                        ClientCode = 19944,
                        ChargeCode = 5112,
                        LsSampleId = new LsSampleId{
                            Prefix = "F",
                            Number = 86573,
                            CheckDigit = 4
                        },
                        CoreSampleReceived = "240423",
                        LsSampleReceived = "240424",
                        TrvMatched = "240424"
                    }
                }
                }
            };
        }


    }

    public class RequestForTestStatusExample : IExamplesProvider<List<RequestForData>>
    {
        public List<RequestForData> GetExamples()
        {
            return new List<RequestForData>()
            {
                new RequestForData {
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
                        SoftwareVersion =  1082
                    },
                    Abn = "72001967184"
                },
                RequestForDataType = new DateTimeRangeRequestForDataType
                {
                    StartDateTimeStatusRequest = "2024-03-21T19:25:04Z"
                }
                }
            };
        }
    }

    public class RequestForTestStatus200Example : IExamplesProvider<ApiResult<List<TestStatus>>>
    {
        public ApiResult<List<TestStatus>> GetExamples()
        {
            return new ApiResult<List<TestStatus>>()
            {
                
                ApiMessages = [],
                Data =  new List<TestStatus>
                {
                    new TestStatus {
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
                            SoftwareVersion =  1082
                        },
                        Abn = "72001967184"
                    },
                    TestStatusDetails = new List<TestStatusDetail>
                {
                    new TestStatusDetail
                    {
                        CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = 1234567,
                        },
                        ClientCode = 19944,
                        ChargeCode = 5112,
                        LsSampleId = new LsSampleId{
                            Prefix = "F",
                            Number = 88568,
                            CheckDigit = 8
                        },
                        CoreSampleReceived = "240423",
                        LsSampleReceived = "240424",
                        TrvMatched = "240424",
                        LsRetuftRequired = LsRetuftRequired.Required
                    },
                    new TestStatusDetail {
                        CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = 1234567,
                        },
                        ClientCode = 19944,
                        ChargeCode = 5112,
                        LsSampleId = new LsSampleId{
                            Prefix = "F",
                            Number = 86573,
                            CheckDigit = 4
                        },
                        CoreSampleReceived = "240423",
                        LsSampleReceived = "240424",
                        TrvMatched = "240424"
                    }
                    }
                }
                }
        };
        }
    }
}
