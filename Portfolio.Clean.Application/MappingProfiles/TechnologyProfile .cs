using AutoMapper;
using Portfolio.Clean.Application.Features.Technology.Queries.GetTechnologyList;
using Portfolio.Clean.Application.Features.Technology.Queries.GetTechnologyDetails;
using Portfolio.Clean.Application.Features.Technology.Commands.CreateTechnology;
using Portfolio.Clean.Application.Features.Technology.Commands.UpdateTechnology;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Portfolio.Clean.Application.MappingProfiles;

public class TechnologyProfile : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public TechnologyProfile()
    {
        CreateMap<TechnologyListDto, Technology>().ReverseMap();
        CreateMap<Technology, TechnologyDetailsDto>();
        CreateMap<CreateTechnologyCommand, Technology>();
        CreateMap<UpdateTechnologyCommand, Technology>();
    }
    #endregion

    #region Methods

    #endregion
}
