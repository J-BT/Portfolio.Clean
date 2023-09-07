using AutoMapper;
using Portfolio.Clean.BlazorUI.Models.ContactEmails;
using Portfolio.Clean.BlazorUI.Services.Base;

namespace Portfolio.Clean.BlazorUI.MappingProfiles;

public class MappingConfig : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public MappingConfig()
    {
        CreateMap<ContactEmailDto, ContactEmailVM>().ReverseMap();
    }
    #endregion

    #region Methods

    #endregion
}
