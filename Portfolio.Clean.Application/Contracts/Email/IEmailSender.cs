using Portfolio.Clean.Application.Models.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Contracts.Email;

public interface IEmailSender
{

	#region Attributes & Accessors

	#endregion

	#region Constructors

	#endregion

	#region Methods
	Task<bool> SendEmail(EmailMessage email);
	#endregion
}
