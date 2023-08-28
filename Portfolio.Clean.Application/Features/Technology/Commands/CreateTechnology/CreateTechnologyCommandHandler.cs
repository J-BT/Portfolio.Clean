using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using Portfolio.Clean.Application.Features.ContactEmail.Commands.CreateContactEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.CreateTechnology;

public class CreateTechnologyCommandHandler : IRequestHandler<CreateTechnologyCommand, int>
{
    private readonly IMapper _mapper;
    private readonly ITechnologyRepository _technologyRepository;

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public CreateTechnologyCommandHandler(IMapper mapper, ITechnologyRepository technologyRepository)
    {
        _mapper = mapper;
        _technologyRepository = technologyRepository;
    }
    #endregion

    #region Methods
    public async Task<int> Handle(CreateTechnologyCommand request, CancellationToken cancellationToken)
    {
        //Validate incoming data
        var validator = new CreateTechnologyCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Any())
            throw new BadRequestException("Invalid Technology", validationResult);

        //Convert to domain entity object
        var technologyToCreate = _mapper.Map<Domain.Technology>(request);

        //Add to database
        await _technologyRepository.CreateAsync(technologyToCreate);

        //Return record id
        return technologyToCreate.Id;
    }
    #endregion

}
