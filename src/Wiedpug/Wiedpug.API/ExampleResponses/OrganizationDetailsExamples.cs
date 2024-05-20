using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.OrganizationDetailsAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class OrganizationDetailsRequestExample : IExamplesProvider<OrganisationDetails>
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
                    DocumentOriginator = "AWTM",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXTS",
                    FinalReceiver = "AWXTS",
                    SoftwareIdentifier = null,
                    ABN = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        OrganisationCode = "AWTS",
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupID="T",
                        TransmitterFlag="Y",
                        ABN = null,
                        PhoneNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number="0389004637"
                            },
                            Extension = null
                        },
                        FaxNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number= "0320874405"
                            }, Extension = null
                        },
                        Addresses= new List<Address> {
                            new Address
                            {
                                FirstName=null,
                                LastName=null,
                                OrganisationName=null,
                                Premise=null,
                                Street="28 GREAT SOUTH ROAD",
                                Suburb="KENSINGTON",
                                City=null,
                                RegionOrState=null,
                                PostCode="3031",
                                Country="AU"
                            }
                        },
                        Contacts= new List<Contact> {
                            new Contact
                            {
                                FirstName="HEAD OFFICE",
                                LastName=null,
                                PhoneNumber= new PhoneNumber {
                                    StandardPhoneNumber = new StandardPhoneNumber{
                                    CountryCode="61",
                                    Number="0310108809"
                                    }, Extension = null
                                },
                                MobileNumber=null,
                                Email=null
                            } 
                        }

                    },
                    new OrganisationDetail
                    {
                        OrganisationCode = "BUY1",
                        NameOfOrganisation = "DEMO BUYER 1",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupID= "E",
                        TransmitterFlag= "N",
                        ABN = null,
                        PhoneNumber= null,
                        FaxNumber= null,
                        Addresses= [],
                        Contacts= []
                    }
                }
            };
        }
    }

    public class OrganizationDetailExample : IExamplesProvider<OrganisationDetails>
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
                    DocumentOriginator = "AWTM",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXTS",
                    FinalReceiver = "AWXTS",
                    SoftwareIdentifier = null,
                    ABN = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Id = "1",
                        OrganisationCode = "AWTS",
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupID="T",
                        TransmitterFlag="Y",
                        ABN = null,
                        PhoneNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number="0389004637"
                            },
                            Extension = null
                        },
                        FaxNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number= "0320874405"
                            }, Extension = null
                        },
                        Addresses= new List<Address> {
                            new Address
                            {
                                FirstName=null,
                                LastName=null,
                                OrganisationName=null,
                                Premise=null,
                                Street="28 GREAT SOUTH ROAD",
                                Suburb="KENSINGTON",
                                City=null,
                                RegionOrState=null,
                                PostCode="3031",
                                Country="AU"
                            }
                        },
                        Contacts= new List<Contact> {
                            new Contact
                            {
                                FirstName="HEAD OFFICE",
                                LastName=null,
                                PhoneNumber= new PhoneNumber {
                                    StandardPhoneNumber = new StandardPhoneNumber{
                                    CountryCode="61",
                                    Number="0310108809"
                                    }, Extension = null
                                },
                                MobileNumber=null,
                                Email=null
                            }
                        }

                    }
                }
            };
        }
    }

    public class OrganizationDetailRequestExample : IExamplesProvider<OrganisationDetails>
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
                    DocumentOriginator = "AWTM",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXTS",
                    FinalReceiver = "AWXTS",
                    SoftwareIdentifier = null,
                    ABN = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        OrganisationCode = "AWTS",
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="2020-04-28",
                        IndustryGroupID="T",
                        TransmitterFlag="Y",
                        ABN = null,
                        PhoneNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number="0389004637"
                            },Extension = null
                        },
                        FaxNumber= new PhoneNumber {
                            StandardPhoneNumber = new StandardPhoneNumber{
                            CountryCode="61",
                            Number= "0320874405"
                            },Extension = null
                        },
                        Addresses= new List<Address> {
                            new Address
                            {
                                FirstName=null,
                                LastName=null,
                                OrganisationName=null,
                                Premise=null,
                                Street="28 GREAT SOUTH ROAD",
                                Suburb="KENSINGTON",
                                City=null,
                                RegionOrState=null,
                                PostCode="3031",
                                Country="AU"
                            }
                        },
                        Contacts= new List<Contact> {
                            new Contact
                            {
                                FirstName="HEAD OFFICE",
                                LastName=null,
                                PhoneNumber= new PhoneNumber {
                                    StandardPhoneNumber = new StandardPhoneNumber{
                                    CountryCode="61",
                                    Number="0310108809"
                                    },Extension=null
                                },
                                MobileNumber=null,
                                Email=null
                            }
                        }

                    }
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
                    ABN = "72001967184",
                    StartDateTimeStatusRequest = "2024-02-01T19:25:04Z",
                    EndDateTimeStatusRequest = "2024-03-21T19:25:04Z",
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
                Data = new OrganisationDetails 
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
                        VersionNumber = "31",
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = "ABC",
                            Version = 10820
                        },
                        ABN = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            OrganisationCode = "AWTS",
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID="T",
                            TransmitterFlag="Y",
                            ABN = null,
                            PhoneNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number="0317229370"
                                },Extension=null
                            },
                            FaxNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number= "03763262290"
                                },Extension=null
                            },
                            Addresses= new List<Address> {
                                new Address
                                {
                                    FirstName=null,
                                    LastName=null,
                                    OrganisationName=null,
                                    Premise=null,
                                    Street="88 HARBOR ROAD",
                                    Suburb="KENSINGTON",
                                    City=null,
                                    RegionOrState=null,
                                    PostCode="3031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName="HEAD OFFICE",
                                    LastName=null,
                                    PhoneNumber= new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0309332782"
                                        }, Extension=null
                                    },
                                    MobileNumber=null,
                                    Email=null
                                }
                            }

                        },
                        new OrganisationDetail
                        {
                            Id = "2",
                            OrganisationCode = "BUY1",
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID= "E",
                            TransmitterFlag= "N",
                            ABN = null,
                            PhoneNumber= null,
                            FaxNumber= null,
                            Addresses= [],
                            Contacts= []
                        },
                        new OrganisationDetail
                        {
                            Id = "3",
                            OrganisationCode = "AWTN",
                            NameOfOrganisation = "AUSTRALIAN WOOL TESTING AUTH LTD",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID= "A",
                            TransmitterFlag= "Y",
                            ABN = null,
                            PhoneNumber= new PhoneNumber
                            {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode = "61",
                                Number = "0254009986"
                                }, Extension=null
                            },
                            FaxNumber= null,
                            Addresses= new List<Address>
                            {
                                new Address
                                {
                                    FirstName=null,
                                    LastName=null,
                                    OrganisationName=null,
                                    Premise=null,
                                    Street="367 NEW HAMMER STREET",
                                    Suburb="NEWCASTLE",
                                    City=null,
                                    RegionOrState=null,
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
                                        }, Extension=null
                                    },
                                    MobileNumber = new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0353298764"
                                        },Extension=null
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

    public class OrganizationDetails200Example : IExamplesProvider<ApiResult>
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
                        DocumentOriginator = "ABCD",
                        CurrentTransmitter = "AWTM",
                        CurrentReceiver = "AWXLC",
                        FinalReceiver = "AWXLC",
                        VersionNumber = "31",
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = "ABC",
                            Version = 10820
                        },
                        ABN = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            OrganisationCode = "AWTS",
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID="T",
                            TransmitterFlag="Y",
                            ABN = null,
                            PhoneNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number="0317229370"
                                },Extension=null
                            },
                            FaxNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number= "03763262290"
                                },Extension=null
                            },
                            Addresses= new List<Address> {
                                new Address
                                {
                                    FirstName=null,
                                    LastName=null,
                                    OrganisationName=null,
                                    Premise=null,
                                    Street="88 HARBOR ROAD",
                                    Suburb="KENSINGTON",
                                    City=null,
                                    RegionOrState=null,
                                    PostCode="3031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName="HEAD OFFICE",
                                    LastName=null,
                                    PhoneNumber= new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0309332782"
                                        }, Extension=null
                                    },
                                    MobileNumber=null,
                                    Email=null
                                }
                            }

                        },
                        new OrganisationDetail
                        {
                            Id = "2",
                            OrganisationCode = "BUY1",
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID= "E",
                            TransmitterFlag= "N",
                            ABN = null,
                            PhoneNumber= null,
                            FaxNumber= null,
                            Addresses= [],
                            Contacts= []
                        },
                        new OrganisationDetail
                        {
                            Id = "3",
                            OrganisationCode = "AWTN",
                            NameOfOrganisation = "AUSTRALIAN WOOL TESTING AUTH LTD",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID= "A",
                            TransmitterFlag= "Y",
                            ABN = null,
                            PhoneNumber= new PhoneNumber
                            {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode = "61",
                                Number = "0254009986"
                                }, Extension=null
                            },
                            FaxNumber= null,
                            Addresses= new List<Address>
                            {
                                new Address
                                {
                                    FirstName=null,
                                    LastName=null,
                                    OrganisationName=null,
                                    Premise=null,
                                    Street="367 NEW HAMMER STREET",
                                    Suburb="NEWCASTLE",
                                    City=null,
                                    RegionOrState=null,
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
                                        }, Extension=null
                                    },
                                    MobileNumber = new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0353298764"
                                        }, Extension = null
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

    public class CreateOrganizationDetails200Example : IExamplesProvider<ApiResult>
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
                        DocumentOriginator = "ABCD",
                        CurrentTransmitter = "AWTM",
                        CurrentReceiver = "AWXLC",
                        FinalReceiver = "AWXLC",
                        VersionNumber = "31",
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = "ABC",
                            Version = 10820
                        },
                        ABN = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            OrganisationCode = "AWTS",
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID="T",
                            TransmitterFlag="Y",
                            ABN = null,
                            PhoneNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number="0317229370"
                                },Extension=null
                            },
                            FaxNumber= new PhoneNumber {
                                StandardPhoneNumber = new StandardPhoneNumber{
                                CountryCode="61",
                                Number= "03763262290"
                                },Extension=null
                            },
                            Addresses= new List<Address> {
                                new Address
                                {
                                    FirstName=null,
                                    LastName=null,
                                    OrganisationName=null,
                                    Premise=null,
                                    Street="88 HARBOR ROAD",
                                    Suburb="KENSINGTON",
                                    City=null,
                                    RegionOrState=null,
                                    PostCode="3031",
                                    Country="AU"
                                }
                            },
                            Contacts= new List<Contact> {
                                new Contact
                                {
                                    FirstName="HEAD OFFICE",
                                    LastName=null,
                                    PhoneNumber= new PhoneNumber {
                                        StandardPhoneNumber = new StandardPhoneNumber{
                                        CountryCode="61",
                                        Number="0309332782"
                                        }, Extension=null
                                    },
                                    MobileNumber=null,
                                    Email=null
                                }
                            }

                        },
                        new OrganisationDetail
                        {
                            Id = "2",
                            OrganisationCode = "BUY1",
                            NameOfOrganisation = "DEMO BUYER 1",
                            DateLastUpdated="2020-04-28",
                            IndustryGroupID= "E",
                            TransmitterFlag= "N",
                            ABN = null,
                            PhoneNumber= null,
                            FaxNumber= null,
                            Addresses= [],
                            Contacts= []
                        }
                }
                }
            };
        }
    }
}


