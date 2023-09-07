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
    protected Response<Guid> ConvertApiException<Guid>(ApiException ex)
    {
        if (ex.StatusCode == 400)
        {
            return new Response<Guid>
            {
                Message = "Invalid data was submitted.",
                ValidationErrors = ex.Response,
                Success = false
            };
        }
        else if (ex.StatusCode == 404)
        {
            return new Response<Guid>
            {
                Message = "The record was not found.",
                ValidationErrors = ex.Response,
                Success = false
            };
        }
        else
        {
            return new Response<Guid>
            {
                Message = "Something went wrong, please try again later.",
                ValidationErrors = ex.Response,
                Success = false
            };
        }
    }
    #endregion
}