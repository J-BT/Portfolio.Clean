namespace Portfolio.Clean.BlazorUI.Services.Base;

public class BaseHttpService
{

    #region Attributes & Accessors

    protected IClient _client;

    #endregion

    #region Constructors
    public BaseHttpService(IClient client)
    {
        _client = client;
    }
    #endregion

    #region Methods

    #endregion
}