using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Persistence.UserSecret;

public class DatabaseUserSecret
{

    #region Attributes & Accessors

    public static string SectionName = "Database";
    public string HostName { get; set; } = string.Empty;
    public string HostPort { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string UserPassword { get; set; } = string.Empty;
    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
