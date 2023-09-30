using AutoMapper;
using Portfolio.Clean.BlazorUI.Models.ContactEmails;
using Portfolio.Clean.BlazorUI.Models.Projects;
using Portfolio.Clean.BlazorUI.Services.Base;

namespace Portfolio.Clean.BlazorUI.MappingProfiles;

public class MappingConfig : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public MappingConfig()
    {
		/*ContactEmail*/
		CreateMap<ContactEmailDto, ContactEmailVM>().ReverseMap();
        CreateMap<CreateContactEmailCommand, ContactEmailVM>().ReverseMap();
        CreateMap<UpdateContactEmailCommand, ContactEmailVM>().ReverseMap();

		/*Project*/
		CreateMap<ProjectDto, ProjectVM>().ReverseMap();
		CreateMap<CreateProjectCommand, ProjectVM>().ReverseMap();
		CreateMap<UpdateProjectCommand, ProjectVM>().ReverseMap();
	}
    #endregion

    #region Methods

    #endregion
}
