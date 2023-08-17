using AutoMapper;
using Portfolio.Clean.Application.Features.ContactEmail.Queries.GetAllContactEmails;
using Portfolio.Clean.Application.Features.ContactEmail.Queries.GetContactEmailDetails;
using Portfolio.Clean.Application.Features.PCLog.Queries.GetAllPCLogs;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.MappingProfiles;

public class ContactEmailProfile : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public ContactEmailProfile()
    {
        CreateMap<ContactEmailDto, ContactEmail>().ReverseMap();
        CreateMap<ContactEmail, ContactEmailDetailsDto>();
        CreateMap<PCLogDto, PCLog>().ReverseMap();
    }
    #endregion

    #region Methods

    #endregion
}
