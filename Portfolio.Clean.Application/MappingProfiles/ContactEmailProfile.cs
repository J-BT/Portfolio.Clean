using AutoMapper;
using Portfolio.Clean.Application.Features.ContactEmail.Commands.CreateContactEmail;
using Portfolio.Clean.Application.Features.ContactEmail.Commands.UpdateContactEmail;
using Portfolio.Clean.Application.Features.ContactEmail.Queries.GetAllContactEmails;
using Portfolio.Clean.Application.Features.ContactEmail.Queries.GetContactEmailDetails;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.MappingProfiles;
/// <summary>
/// ContactEmailProfile which inherits of 'AutoMapper.Profile' class, creates a mapping for all ContactEmail entities.
/// According to the CQRS (Command and Query Responsibility Segregation) pattern, 
/// Domain entites are converted into DTO (Data Transfert Object) inside 'Queries' features and Command entites are
/// converted into Domain entites inside 'Commands' features.
/// </summary>
public class ContactEmailProfile : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public ContactEmailProfile()
    {
        CreateMap<ContactEmail, ContactEmailDto>().ReverseMap();
        CreateMap<ContactEmail, ContactEmailDetailsDto>().ReverseMap();
        CreateMap<CreateContactEmailCommand, ContactEmail>();
        CreateMap<UpdateContactEmailCommand, ContactEmail>();
    }
    #endregion

    #region Methods

    #endregion
}
