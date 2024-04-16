using Microsoft.VisualBasic.FileIO;
using Swashbuckle.AspNetCore.Filters;
using System.Security.Cryptography.Xml;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.OrganizationDetailsAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class OrganizationDetailsRequestExample : IExamplesProvider<OrganizationDetails>
    {
        public OrganizationDetails GetExamples()
        {
            return new OrganizationDetails()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    AccessPassword = "1111111111",
                    AccessPasswordReplacement = null,
                    TransmissionType = TransmissionType.AuctionCatalogues,
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = "Talman",
                        Version = 10820
                    },
                    Abn = "72001967184"
                },
                OrganizationDetailCollection = new List<OrganizationDetail>
                {
                }
            };
        }
    }

    public class GetOrganizationDetailsRequestExample : IExamplesProvider<GetOrganizationDetailsRequest>
    {
        public GetOrganizationDetailsRequest GetExamples()
        {
            return new GetOrganizationDetailsRequest()
            {
                    CountryOfOrigin = CountryCode.AU,
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = "Talman",
                        Version = 10820
                    },
                    Abn = "72001967184",
                    StartDateTimeStatusRequest = "2024-02-01T19:25:04+00:00",
                    EndDateTimeStatusRequest = "2024-03-21T19:25:04+00:00",
                    UserNetworkDateTime = true
            };
        }
    }

    public class GetOrganizationDetails200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new OrganizationDetails 
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = "ABCD",
                        CurrentTransmitter = "AWTM",
                        CurrentReceiver = "AWXLC",
                        FinalReceiver = "AWXLC",
                        AccessPassword = "1111111111",
                        AccessPasswordReplacement = null,
                        TransmissionType = TransmissionType.AuctionCatalogues,
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = "Talman",
                            Version = 10820
                        },
                        Abn = "72001967184"
                    },
                    OrganizationDetailCollection = new List<OrganizationDetail>
                    {
                    }
                }
            };
        }
    }

    public class OrganizationDetails200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = null
            };
        }
    }
}
