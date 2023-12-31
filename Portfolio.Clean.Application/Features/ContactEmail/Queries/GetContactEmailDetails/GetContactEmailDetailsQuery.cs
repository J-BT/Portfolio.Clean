﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Queries.GetContactEmailDetails;

public record GetContactEmailDetailsQuery(int Id) : IRequest<ContactEmailDetailsDto>;
