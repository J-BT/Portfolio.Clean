using FluentValidation.Results;

namespace Portfolio.Clean.Application.Exceptions;

public class BadRequestException : Exception
{

    #region Attributes & Accessors
    public IDictionary<string, string[]> ValidationErrors { get; set; }
    #endregion

    #region Constructors
    public BadRequestException(string message) 
        : base(message)
    {

    }

    public BadRequestException(string message, ValidationResult validationResult) 
        : base(message)
    {
        ValidationErrors = validationResult.ToDictionary();
    }
    #endregion

    #region Methods

    #endregion
}
