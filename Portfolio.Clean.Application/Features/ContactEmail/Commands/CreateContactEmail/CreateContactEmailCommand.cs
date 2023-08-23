using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Features.ContactEmail.Commands.CreateContactEmail;

public class CreateContactEmailCommand : IRequest<int>
{

    #region Attributes & Accessors
    public string ContactEmailObject { get; set; } = string.Empty;
    public string ContactEmailContent { get; set; } = string.Empty;
    public string ContactEmailSender { get; set; } = string.Empty;
    public bool ContactEmailIsSent { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? LastUpdate { get; set; }
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
