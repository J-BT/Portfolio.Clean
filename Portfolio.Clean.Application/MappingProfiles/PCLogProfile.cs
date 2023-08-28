using AutoMapper;
using Portfolio.Clean.Application.Features.PCLog.Commands.CreatePCLog;
using Portfolio.Clean.Application.Features.PCLog.Commands.UpdatePCLog;
using Portfolio.Clean.Application.Features.PCLog.Queries.GetAllPCLogs;
using Portfolio.Clean.Application.Features.PCLog.Queries.GetPCLogDetails;
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
        CreateMap<PCLog, PCLogDto>().ReverseMap();
        CreateMap<PCLog, PCLogDetailsDto>().ReverseMap();
        CreateMap<CreatePCLogCommand, PCLog>();
        CreateMap<UpdatePCLogCommand, PCLog>();
    }
    #endregion

    #region Methods

    #endregion
}
