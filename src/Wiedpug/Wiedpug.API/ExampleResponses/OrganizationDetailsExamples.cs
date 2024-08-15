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
                                                OrganisationCode = "AWS",
                    },
                    CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",
                    },
                    Abn = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Organisation = new Organisation
                            {
                                                        OrganisationCode = "AWS",
                            },
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId= IndustryGroupId.T,
                        IsTransmitter=true,
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
                                Name = new Name
                                {
                                    OrganisationName = "AWTS"
                                },
                                Premise = "Suite 210",
                                StreetAddressLine1="28 GREAT SOUTH ROAD",
                                StreetAddressLine2="KENSINGTON",
                                AdministrativeArea = "NSW",
                                Locality = "Sydney",
                                PostCode="3031",
                                Country=CountryCode.AU
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
                                                        OrganisationCode = "ABC",
                            },
                        NameOfOrganisation = "DEMO BUYER 1",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId= IndustryGroupId.E,
                        IsTransmitter= false
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
                                                OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",
                    },
                    Abn = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Id = "1",
                        Organisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",
                            },
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId=IndustryGroupId.T,
                        IsTransmitter=true,
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
                                Name = new Name
                                {
                                    OrganisationName = "AWTM"
                                },
                                Premise = "3402A",
                                StreetAddressLine1="28 GREAT SOUTH ROAD",
                                StreetAddressLine2="KENSINGTON",
                                AdministrativeArea = "NSW",
                                Locality = "Sydney",
                                PostCode="3031",
                                Country=CountryCode.AU
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
                                                OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",
                    },
                    Abn = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Organisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",
                            },
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupId= IndustryGroupId.E,
                        IsTransmitter=true,
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
                                Name = new Name
                                {
                                    OrganisationName = "AWTS"
                                },
                                Premise = "Room L104",
                                StreetAddressLine1="28 GREAT SOUTH ROAD",
                                StreetAddressLine2="KENSINGTON",
                                AdministrativeArea = "NSW",
                                Locality = "Sydney",
                                PostCode="3031",
                                Country=CountryCode.AU
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
                    Abn = "72001967184"
                },
                CountryOfOrigin = CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                                                OrganisationCode = "ABC",
                    },
                SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        Version = 1082
                    },
                    Abn = "72001967184",
                    StartDateTimeStatusRequest = "2024-02-01T19:25:04Z",
                    EndDateTimeStatusRequest = "2024-03-21T19:25:04Z",
                    IsUsingNetworkDateTime = true
            };
        }
    }

    public class GetOrganisationDetails200Example : IExamplesProvider<ApiResult<OrganisationDetails>>
    {
        public ApiResult<OrganisationDetails> GetExamples()
        {
            return new ApiResult<OrganisationDetails>()
            {
                
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
                            SoftwareCompany = SoftwareCompany.Modiano,
                            Version = 1082
                        },
                        Abn = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            Organisation = new Organisation
                            {
                                                        OrganisationCode = "AWS",
                            },
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            IsTransmitter=true,
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
                                Name = new Name
                                {
                                    OrganisationName = "AWTS"
                                },
                                Premise = "Suite 130",
                                StreetAddressLine1="88 Harbor ROAD",
                                StreetAddressLine2="KENSINGTON",
                                AdministrativeArea = "NSW",
                                Locality = "Sydney",
                                PostCode="3031",
                                Country=CountryCode.AU
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
                                                        OrganisationCode = "ABC",
                            },
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            IsTransmitter= false
                        },
                        new OrganisationDetail
                        {
                            Id = "3",
                            Organisation = new Organisation
                            {
                                                        OrganisationCode = "AWS",
                            },
                            NameOfOrganisation = "AUSTRALIAN WOOL TESTING AUTH LTD",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.A,
                            IsTransmitter= true,
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
                                    Name = new Name
                                    {
                                        OrganisationName = "AWTS"
                                    },
                                    Premise = "Box 201",
                                    StreetAddressLine1="367 NEW HAMMER STREET",
                                    StreetAddressLine2="NEWCASTLE",
                                    AdministrativeArea = "NSW",
                                    Locality = "Sydney",
                                    PostCode="2031",
                                    Country=CountryCode.AU
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
                        Abn = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            Organisation = new Organisation
                            {
                                                        OrganisationCode = "AWT",
                            },
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId=IndustryGroupId.E,
                            IsTransmitter=true,
                            Abn = null,
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
                                    Name = new Name
                                    {
                                        OrganisationName = "AWTS"
                                    },
                                    Premise = "Box 201",
                                    StreetAddressLine1="367 NEW HAMMER STREET",
                                    StreetAddressLine2="NEWCASTLE",
                                    AdministrativeArea = "NSW",
                                    Locality = "Sydney",
                                    PostCode="3031",
                                    Country=CountryCode.AU

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
                                                        OrganisationCode = "BY1",
                            },
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            IsTransmitter= false
                        },
                        new OrganisationDetail
                        {
                            Id = "3",
                            Organisation = new Organisation
                            {
                                                        OrganisationCode = "AWS",
                            },
                            NameOfOrganisation = "AUSTRALIAN WOOL TESTING AUTH LTD",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.A,
                            IsTransmitter= true,
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
                                    Name = new Name
                                    {
                                        OrganisationName = "AWTS"
                                    },
                                    Premise = "Box 201",
                                    StreetAddressLine1="367 NEW HAMMER STREET",
                                    StreetAddressLine2="NEWCASTLE",
                                    AdministrativeArea = "NSW",
                                    Locality = "Sydney",
                                    PostCode="2031",
                                    Country=CountryCode.AU
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
                        Abn = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            Organisation = new Organisation
                            {
                                                        OrganisationCode = "AWT",
                            },
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId=IndustryGroupId.T,
                            IsTransmitter=true,
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
                                    Name = new Name
                                    {
                                        OrganisationName = "AWTS"
                                    },
                                    Premise = "Suite 210",
                                    StreetAddressLine1="28 GREAT SOUTH ROAD",
                                    StreetAddressLine2="KENSINGTON",
                                    AdministrativeArea = "NSW",
                                    Locality = "Sydney",
                                    PostCode="3031",
                                    Country=CountryCode.AU
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
                                                        OrganisationCode = "BY1",
                            },
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupId= IndustryGroupId.E,
                            IsTransmitter= false
                        }
                }
                }
            };
        }
    }
}


