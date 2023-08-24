﻿using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.PCLog.Commands.CreatePCLog;

public class CreatePCLogCommandHandler : IRequestHandler<CreatePCLogCommand, int>
{
    #region Attributes & Accessors

    private readonly IMapper _mapper;
    private readonly IPCLogRepository _pCLogRepository;

    #endregion

    #region Constructors
    public CreatePCLogCommandHandler(IMapper mapper, IPCLogRepository pCLogRepository)
    {
        _mapper = mapper;
        _pCLogRepository = pCLogRepository;
    }

    public async Task<int> Handle(CreatePCLogCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data

        //Convert to domain entity object
        var PcLogToCreate = _mapper.Map<Domain.PCLog>(request);

        //Add to database
        await _pCLogRepository.CreateAsync(PcLogToCreate);

        //Return record id
        return PcLogToCreate.Id;
    }
    #endregion

    #region Methods

    #endregion
}
