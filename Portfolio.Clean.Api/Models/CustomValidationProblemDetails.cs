using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Clean.Api.Models;

public class CustomValidationProblemDetails : ProblemDetails
{

    #region Attributes & Accessors
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
