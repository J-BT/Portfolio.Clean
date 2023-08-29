using Portfolio.Clean.Application.Contracts.Email;
using Portfolio.Clean.Application.Models.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Infrastructure.EmailService;

public class EmailSender : IEmailSender
{

    #region Attributes & Accessors

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public Task<bool> SendEmail(EmailMessage email)
    {
        throw new NotImplementedException();
    }
    #endregion

}
