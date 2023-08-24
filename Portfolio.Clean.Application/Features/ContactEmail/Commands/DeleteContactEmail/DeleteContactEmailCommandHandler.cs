using AutoMapper;
using MediatR;
using Portfolio.Clean.Application.Contracts.Persistence;
using Portfolio.Clean.Application.Exceptions;
using Portfolio.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.DeleteContactEmail;

public class DeleteContactEmailCommandHandler : IRequestHandler<DeleteContactEmailCommand, Unit>
{
    #region Attributes & Accessors

    private readonly IContactEmailRepository _contactEmailRepository;

    #endregion

    #region Constructors
    public DeleteContactEmailCommandHandler(IContactEmailRepository contactEmailRepository)
    {
        _contactEmailRepository = contactEmailRepository;
    }
    #endregion

    #region Methods
    public async Task<Unit> Handle(DeleteContactEmailCommand request, CancellationToken cancellationToken)
    {

        //Retrieve domain entity object
        var contactEmailToDelete = await _contactEmailRepository.GetAsyncById(request.Id);

        //Verify that record exists
        if(contactEmailToDelete == null) 
            throw new NotFoundException(nameof(ContactEmail), request.Id);
       
        //Remove to database
        await _contactEmailRepository.DeleteAsync(contactEmailToDelete);

        //Return Unit Value (== void)
        return Unit.Value;
    }
    #endregion

}
