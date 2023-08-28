using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.UpdateTechnology;

public class UpdateTechnologyCommandHandler : IRequestHandler<UpdateTechnologyCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ITechnologyRepository _technologyRepository;

    #region Attributes & Accessors

    #endregion

    #region Constructors
    public UpdateTechnologyCommandHandler(IMapper mapper, ITechnologyRepository technologyRepository)
    {
        _mapper = mapper;
        _technologyRepository = technologyRepository;
    }
    #endregion

    #region Methods
    public async Task<Unit> Handle(UpdateTechnologyCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming data
        var validator = new UpdateTechnologyCommandValidator(_technologyRepository);
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Any())
            throw new BadRequestException("Invalid Technology", validationResult);

        // Convert domain to entity object
        var technologyToUpdate = _mapper.Map<Domain.Technology>(request);
            
        // Add to database
        await _technologyRepository.UpdateAsync(technologyToUpdate);

        // Return Unit value
        return Unit.Value;
    }
    #endregion

}
