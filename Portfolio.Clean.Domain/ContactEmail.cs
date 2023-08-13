using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain;

public class ContactEmail
{
    #region Attributes & Properties

    public int IdContactEmail { get; set; }
    public string ContactEmailObject { get; set; } = string.Empty;
    public string ContactEmailContent { get; set; } = string.Empty;
    public string ContactEmailSender { get; set; } = string.Empty;
    public bool ContactEmailIsSent { get; set; }
    public DateTime ContactEmailCreationDate { get; set; }
    public DateTime ContactEmailLastUpdate { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
