using Portfolio.Clean.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain;

public class ContactEmail : BaseEntity
{
    #region Attributes & Accessors

    public string ContactEmailObject { get; set; } = string.Empty;
    public string ContactEmailContent { get; set; } = string.Empty;
    public string ContactEmailSender { get; set; } = string.Empty;

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
