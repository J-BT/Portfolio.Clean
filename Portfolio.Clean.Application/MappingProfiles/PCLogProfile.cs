using AutoMapper;
using Portfolio.Clean.Application.Features.PCLog.Queries.GetAllPCLogs;
using Portfolio.Clean.Application.Features.PCLogs.Queries.GetPCLogDetails;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.MappingProfiles;

public class PCLogProfile : Profile
{

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public PCLogProfile()
    {
        CreateMap<PCLogDto, PCLog>().ReverseMap();
        CreateMap<PCLog, PCLogDetailsDto>();
    }
    #endregion

    #region Methods

    #endregion
}
