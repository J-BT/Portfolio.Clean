using FluentValidation.Results;

namespace Portfolio.Clean.Application.Exceptions;

public class BadRequestException : Exception
{

    #region Attributes & Accessors
    public List<string> ValidationErrors { get; set; }
    #endregion

    #region Constructors
    public BadRequestException(string message) 
        : base(message)
    {

    }

    public BadRequestException(string message, ValidationResult validationResult) 
        : base(message)
    {
        ValidationErrors = new();
        foreach(var error in validationResult.Errors)
        {
            ValidationErrors.Add(error.ErrorMessage);
        }
    }
    #endregion

    #region Methods

    #endregion
}
