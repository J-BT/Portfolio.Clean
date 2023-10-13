namespace Portfolio.Clean.Application.Models.Email;

/// <summary>
/// Gathers the elements required to send an email
/// </summary>
public class EmailSettings
{

    #region Attributes & Accessors

    public string ApiKey { get; set; } = string.Empty;
    public string FromAddress { get; set; } = string.Empty;
    public string FromName { get; set; } = string.Empty;
    public string To { get; set; } = string.Empty;

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}

