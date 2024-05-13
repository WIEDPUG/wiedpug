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
                    DateFormatLastRevised = "200715",
                    DateTransmissionFileCreated = "160117",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = "AWTM",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXTS",
                    FinalReceiver = "AWXTS",
                    SoftwareIdentifier = null,
                    Abn = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        OrganisationCode = "AWTS",
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="200428",
                        IndustryGroupID="T",
                        TransmitterFlag="Y",
                        Abn = null,
                        PhoneNumber= new PhoneNumber {
                            CountryCode="61",
                            Number="03 89004637"
                        },
                        FaxNumber= new PhoneNumber {
                            CountryCode="61",
                            Number= "03 20874405"
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
                                    CountryCode="61",
                                    Number="03 10108809"
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
                        DateLastUpdated="200428",
                        IndustryGroupID= "E",
                        TransmitterFlag= "N",
                        Abn = null,
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
                    DateFormatLastRevised = "200715",
                    DateTransmissionFileCreated = "160117",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = "AWTM",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXTS",
                    FinalReceiver = "AWXTS",
                    SoftwareIdentifier = null,
                    Abn = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        Id = "1",
                        OrganisationCode = "AWTS",
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="200428",
                        IndustryGroupID="T",
                        TransmitterFlag="Y",
                        Abn = null,
                        PhoneNumber= new PhoneNumber {
                            CountryCode="61",
                            Number="03 89004637"
                        },
                        FaxNumber= new PhoneNumber {
                            CountryCode="61",
                            Number= "03 20874405"
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
                                    CountryCode="61",
                                    Number="03 10108809"
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
                    DateFormatLastRevised = "200715",
                    DateTransmissionFileCreated = "160117",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = "AWTM",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXTS",
                    FinalReceiver = "AWXTS",
                    SoftwareIdentifier = null,
                    Abn = "43006014106"
                },
                OrganisationDetailCollection = new List<OrganisationDetail>
                {
                    new OrganisationDetail
                    {
                        OrganisationCode = "AWTS",
                        NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                        DateLastUpdated="200428",
                        IndustryGroupID="T",
                        TransmitterFlag="Y",
                        Abn = null,
                        PhoneNumber= new PhoneNumber {
                            CountryCode="61",
                            Number="03 89004637"
                        },
                        FaxNumber= new PhoneNumber {
                            CountryCode="61",
                            Number= "03 20874405"
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
                                    CountryCode="61",
                                    Number="03 10108809"
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
                Data = new OrganisationDetails 
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "200715",
                        DateTransmissionFileCreated = "160117",
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
                        Abn = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            OrganisationCode = "AWTS",
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="200428",
                            IndustryGroupID="T",
                            TransmitterFlag="Y",
                            Abn = null,
                            PhoneNumber= new PhoneNumber {
                                CountryCode="61",
                                Number="03 17229370"
                            },
                            FaxNumber= new PhoneNumber {
                                CountryCode="61",
                                Number= "03 763262290"
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
                                        CountryCode="61",
                                        Number="03 09332782"
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
                            DateLastUpdated="200428",
                            IndustryGroupID= "E",
                            TransmitterFlag= "N",
                            Abn = null,
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
                            DateLastUpdated="200428",
                            IndustryGroupID= "A",
                            TransmitterFlag= "Y",
                            Abn = null,
                            PhoneNumber= new PhoneNumber
                            {
                                CountryCode = "61",
                                Number = "02 5400 9986"
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
                                        CountryCode="61",
                                        Number="03 87569072"
                                    },
                                    MobileNumber = new PhoneNumber {
                                        CountryCode="61",
                                        Number="03 53298764"
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
                        DateFormatLastRevised = "200715",
                        DateTransmissionFileCreated = "160117",
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
                        Abn = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            OrganisationCode = "AWTS",
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="200428",
                            IndustryGroupID="T",
                            TransmitterFlag="Y",
                            Abn = null,
                            PhoneNumber= new PhoneNumber {
                                CountryCode="61",
                                Number="03 17229370"
                            },
                            FaxNumber= new PhoneNumber {
                                CountryCode="61",
                                Number= "03 763262290"
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
                                        CountryCode="61",
                                        Number="03 09332782"
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
                            DateLastUpdated="200428",
                            IndustryGroupID= "E",
                            TransmitterFlag= "N",
                            Abn = null,
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
                            DateLastUpdated="200428",
                            IndustryGroupID= "A",
                            TransmitterFlag= "Y",
                            Abn = null,
                            PhoneNumber= new PhoneNumber
                            {
                                CountryCode = "61",
                                Number = "02 5400 9986"
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
                                        CountryCode="61",
                                        Number="03 87569072"
                                    },
                                    MobileNumber = new PhoneNumber {
                                        CountryCode="61",
                                        Number="03 53298764"
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
                        DateFormatLastRevised = "200715",
                        DateTransmissionFileCreated = "160117",
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
                        Abn = "72001925678"
                    },
                    OrganisationDetailCollection = new List<OrganisationDetail>
                    {
                        new OrganisationDetail
                        {
                            Id = "1",
                            OrganisationCode = "AWTS",
                            NameOfOrganisation = "AWTA - EDI TESTING BY EXTERNAL CLIENTS",
                            DateLastUpdated="200428",
                            IndustryGroupID="T",
                            TransmitterFlag="Y",
                            Abn = null,
                            PhoneNumber= new PhoneNumber {
                                CountryCode="61",
                                Number="03 17229370"
                            },
                            FaxNumber= new PhoneNumber {
                                CountryCode="61",
                                Number= "03 763262290"
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
                                        CountryCode="61",
                                        Number="03 09332782"
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
                            DateLastUpdated="200428",
                            IndustryGroupID= "E",
                            TransmitterFlag= "N",
                            Abn = null,
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


