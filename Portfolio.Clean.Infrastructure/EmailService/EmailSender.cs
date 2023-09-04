using Microsoft.Extensions.Options;
using Portfolio.Clean.Application.Contracts.Email;
using Portfolio.Clean.Application.Models.Email;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Infrastructure.EmailService;

public class EmailSender : IEmailSender
{

    #region Attributes & Accessors
    public EmailSettings _emailSettings { get; set; }
    #endregion

    #region Constructors
    public EmailSender(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }
    #endregion

    #region Methods
    public async Task<bool> SendEmail(EmailMessage email)
    {
        //OK
        var client = new SendGridClient(_emailSettings.ApiKey);
        var to = new EmailAddress(_emailSettings.To);
        var from = new EmailAddress
        {
            Email = _emailSettings.FromAddress,
            Name = _emailSettings.FromName
        };

        var message = MailHelper.CreateSingleEmail(from, to, email.Subject,
            email.Body, email.Body);

        var response = await client.SendEmailAsync(message);

        return response.IsSuccessStatusCode; //Return true OK or Accepted
    }
    #endregion

}
