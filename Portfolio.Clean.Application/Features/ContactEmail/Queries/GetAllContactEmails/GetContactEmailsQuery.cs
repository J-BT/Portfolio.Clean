using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Queries.GetAllContactEmails;

public record GetContactEmailsQuery : IRequest<List<ContactEmailDto>>;
