﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.Technology.Commands.CreateTechnology;

public class CreateTechnologyCommand : IRequest<int>
{

    #region Attributes & Accessors
    public string TechnoName { get; set; } = string.Empty;
    public byte[]? TechnoImg { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? LastUpdate { get; set; }
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}