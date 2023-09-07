namespace Portfolio.Clean.BlazorUI.Services.Base;

public class Response<T>
{

    #region Attributes & Accessors
    public string Message { get; set; } = string.Empty;
    public string ValidationErrors { get; set; } = string.Empty;
    public bool Success { get; set; }
    public T Data { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}