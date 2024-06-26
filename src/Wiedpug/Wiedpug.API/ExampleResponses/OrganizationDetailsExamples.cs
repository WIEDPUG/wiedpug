using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.OrganisationDetailsAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class OrganisationDetailsRequestExample : IExamplesProvider<OrganisationDetails>
    {
        public OrganisationDetails GetExamples()
        {
            return new OrganisationDetails()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "AWTM"
                    },
                    ABN = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Organisation = new Organisation
                            {
                                OrganisationCode = "AWTS"
                            },
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId= IndustryGroupId.T,
                        TransmitterFlag="Y",
                        PhoneNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number="0389004637"
                            }
                        },
                        FaxNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number= "0320874405"
                            }
                        },
                        Addresses= new List<Address> {
                            new Address
                            {
                                Street="28 GREAT SOUTH ROAD",
                                Suburb="KENSINGTON",
                                PostCode="3031",
                                Country="AU"
                            }
                        },
                        Contacts= new List<Contact> {
                            new Contact
                            {
                                FirstName="HEAD OFFICE",
                                PhoneNumber= new PhoneNumber {
                                    StandardPhoneNumber = new StandardPhoneNumber{
                                    CountryCode="61",
                                    Number="0310108809"
                                    }
                                }
                            } 
                        }

                    },
                    new OrganisationDetail
                    {
                        Organisation = new Organisation
                            {
                                OrganisationCode = "ABCD"
                            },
                        NameOfOrganisation = "DEMO BUYER 1",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId= IndustryGroupId.E,
                        TransmitterFlag= "N"
                    }
                }
            };
        }
    }

    public class OrganisationDetailExample : IExamplesProvider<OrganisationDetails>
    {
        public OrganisationDetails GetExamples()
        {
            return new OrganisationDetails()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABCD"
                    },
                    ABN = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Id = "1",
                        Organisation = new Organisation
                            {
                                OrganisationCode = "ABCD"
                            },
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId=IndustryGroupId.T,
                        TransmitterFlag="Y",
                        PhoneNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number="0389004637"
                            }
                        },
                        FaxNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number= "0320874405"
                            }
                        },
                        Addresses= new List<Address> {
                            new Address
                            {
                                Street="28 GREAT SOUTH ROAD",
                                Suburb="KENSINGTON",
                                PostCode="3031",
                                Country="AU"
                            }
                        },
                        Contacts= new List<Contact> {
                            new Contact
                            {
                                FirstName="HEAD OFFICE",
                                PhoneNumber= new PhoneNumber {
                                    StandardPhoneNumber = new StandardPhoneNumber{
                                    CountryCode="61",
                                    Number="0310108809"
                                    }
                                }
                            }
                        }

                    }
                }
            };
        }
    }

    public class OrganisationDetailRequestExample : IExamplesProvider<OrganisationDetails>
    {
        public OrganisationDetails GetExamples()
        {
            return new OrganisationDetails()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABCD"
                    },
                    ABN = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Organisation = new Organisation
                            {
                                OrganisationCode = "ABCD"
                            },
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId= IndustryGroupId.E,
                        TransmitterFlag="Y",
                        PhoneNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number="0389004637"
                            }
                        },
                        FaxNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number= "0320874405"
                            }
                        },
                        Addresses= new List<Address> {
                            new Address
                            {
                                Street="28 GREAT SOUTH ROAD",
                                Suburb="KENSINGTON",
                                PostCode="3031",
                                Country="AU"
                            }
                        },
                        Contacts= new List<Contact> {
                            new Contact
                            {
                                FirstName="HEAD OFFICE",
                                PhoneNumber= new PhoneNumber {
                                    StandardPhoneNumber = new StandardPhoneNumber{
                                    CountryCode="61",
                                    Number="0310108809"
                                    }
                                },
                            }
                        }

                    }
                }
            };
        }
    }

    public class GetOrganisationDetailsRequestExample : IExamplesProvider<GetOrganisationDetailsRequest>
    {
        public GetOrganisationDetailsRequest GetExamples()
        {
            return new GetOrganisationDetailsRequest()
            {
                    CountryOfOrigin = CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABCD"
                    },
                SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        Version = 1082
                    },
                    ABN = "72001967184",
                    StartDateTimeStatusRequest = "2024-02-01T19:25:04Z",
                    EndDateTimeStatusRequest = "2024-03-21T19:25:04Z",
                    UseNetworkDateTime = true
            };
        }
    }

    public class GetOrganisationDetails200Example : IExamplesProvider<ApiResult<OrganisationDetails>>
    {
        public ApiResult<OrganisationDetails> GetExamples()
        {
            return new ApiResult<OrganisationDetails>()
            {
                IsSuccessful = true,
                Message = null,
                Data = new OrganisationDetails 
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ABCD"
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Modiano,
                            Version = 1082
                        },
                        ABN = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "AWTS"
                            },
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            TransmitterFlag="Y",
                            PhoneNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number="0317229370"
                                }
                            },
                            FaxNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number= "03763262290"
                                }
                            },
                            Addresses= new List<Address> {
                                new Address
                                {
                                    Street="88 HARBOR ROAD",
                                    Suburb="KENSINGTON",
                                    PostCode="3031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName="HEAD OFFICE",
                                    PhoneNumber= new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0309332782"
                                        }
                                    }
                                }
                            }

                        },
                        new OrganisationDetail
                        {
                            Id = "2",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "ABCD"
                            },
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            TransmitterFlag= "N"
                        },
                        new OrganisationDetail
                        {
                            Id = "3",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "AWTN"
                            },
                            NameOfOrganisation = "AUSTRALIAN WOOL TESTING AUTH LTD",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.A,
                            TransmitterFlag= "Y",
                            PhoneNumber= new PhoneNumber
                            {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode = "61",
                                Number = "0254009986"
                                }
                            },
                            Addresses= new List<Address>
                            {
                                new Address
                                {
                                    Street="367 NEW HAMMER STREET",
                                    Suburb="NEWCASTLE",
                                    PostCode="2031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName = "MIKE",
                                    LastName = "PWOELL",
                                    PhoneNumber = new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0387569072"
                                        }
                                    },
                                    MobileNumber = new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0353298764"
                                        }
                                    },
                                    Email= "mpowell@awtn.co.au"
                                }
                            }
                        }
                    }
                }
            };
        }
    }

    public class OrganisationDetails200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new OrganisationDetails
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ABCD"
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.AWTA,
                            Version = 1082
                        },
                        ABN = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "AWTA"
                            },
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId=IndustryGroupId.E,
                            TransmitterFlag="Y",
                            ABN = null,
                            PhoneNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number="0317229370"
                                }
                            },
                            FaxNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number= "03763262290"
                                }
                            },
                            Addresses= new List<Address> {
                                new Address
                                {
                                    Street="88 HARBOR ROAD",
                                    Suburb="KENSINGTON",
                                    PostCode="3031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName="HEAD OFFICE",
                                    PhoneNumber= new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0309332782"
                                        }
                                    }
                                }
                            }

                        },
                        new OrganisationDetail
                        {
                            Id = "2",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "BUY1"
                            },
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            TransmitterFlag= "N"
                        },
                        new OrganisationDetail
                        {
                            Id = "3",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "AWTN"
                            },
                            NameOfOrganisation = "AUSTRALIAN WOOL TESTING AUTH LTD",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.A,
                            TransmitterFlag= "Y",
                            PhoneNumber= new PhoneNumber
                            {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode = "61",
                                Number = "0254009986"
                                }
                            },
                            Addresses= new List<Address>
                            {
                                new Address
                                {

                                    Street="367 NEW HAMMER STREET",
                                    Suburb="NEWCASTLE",
                                    PostCode="2031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName = "MIKE",
                                    LastName = "PWOELL",
                                    PhoneNumber = new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0387569072"
                                        }
                                    },
                                    MobileNumber = new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0353298764"
                                        }
                                    },
                                    Email= "mpowell@awtn.co.au"
                                }
                            }
                        }
                    }
                }
            };
        }
    }

    public class CreateOrganisationDetails200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new OrganisationDetails
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ABCD"
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.AWTA,
                            Version = 1082
                        },
                        ABN = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "AWTA"
                            },
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId=IndustryGroupId.T,
                            TransmitterFlag="Y",
                            PhoneNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number="0317229370"
                                }
                            },
                            FaxNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number= "03763262290"
                                }
                            },
                            Addresses= new List<Address> {
                                new Address
                                {

                                    Street="88 HARBOR ROAD",
                                    Suburb="KENSINGTON",
                                    PostCode="3031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName="HEAD OFFICE",
                                    PhoneNumber= new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0309332782"
                                        }
                                    }
                                }
                            }

                        },
                        new OrganisationDetail
                        {
                            Id = "2",
                            Organisation = new Organisation
                            {
                                OrganisationCode = "BUY1"
                            },
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            TransmitterFlag= "N"
                        }
                }
                }
            };
        }
    }
}


