using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.DeleteTechnology;

public class DeleteTechnologyCommandHandler : IRequestHandler<DeleteTechnologyCommand, Unit>
{

    #region Attributes & Accessors

    private readonly ITechnologyRepository _technologyRepository;

    #endregion

    #region Constructors
    public DeleteTechnologyCommandHandler(ITechnologyRepository technologyRepository)
    {
        _technologyRepository = technologyRepository;
    }
    #endregion

    #region Methods
    public async Task<Unit> Handle(DeleteTechnologyCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the entity object
        var technologyToDelete = await _technologyRepository.GetAsyncById(request.Id);

        // Verify that record exists
        if (technologyToDelete == null)
            throw new NotFoundException(nameof(Technology), request.Id);

        // Remove it to the database
        await _technologyRepository.DeleteAsync(technologyToDelete);

        // Return Unit value
        return Unit.Value;

    }
    #endregion

}
