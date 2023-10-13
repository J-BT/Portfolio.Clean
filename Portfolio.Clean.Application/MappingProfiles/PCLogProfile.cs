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
/// <summary>
/// PCLogProfile which inherits of 'AutoMapper.Profile' class, creates a mapping for all PCLog entities.
/// According to the CQRS (Command and Query Responsibility Segregation) pattern, 
/// Domain entites are converted into DTO (Data Transfert Object) inside 'Queries' features and Command entites are
/// converted into Domain entites inside 'Commands' features.
/// </summary>
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
