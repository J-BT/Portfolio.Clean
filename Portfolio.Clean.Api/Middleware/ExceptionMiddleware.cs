﻿using Portfolio.Clean.Api.Models;
using Portfolio.Clean.Application.Exceptions;
using System.Net;

namespace Portfolio.Clean.Api.Middleware;
/// <summary>
/// Middleware enabling to use all the customed Exceptions defined in the 'Application' layer.
/// Then the following command 'app.UseMiddleware<ExceptionMiddleware>();' must be added in Program.cs 
/// to implement this class into the 'Api' layer. 
/// </summary>
public class ExceptionMiddleware
{


    #region Attributes & Accessors

    private readonly RequestDelegate _next;

    #endregion

    #region Constructors
    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    #endregion

    #region Methods
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
    {
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
        CustomValidationProblemDetails problem = new();

        switch (ex)
        {
            case BadRequestException badRequestException:
                statusCode = HttpStatusCode.BadRequest;
                problem = new CustomValidationProblemDetails
                {
                    Title = badRequestException.Message,
                    Status = (int)statusCode,
                    Detail = badRequestException.InnerException?.Message,
                    Type = nameof(BadRequestException),
                    Errors = badRequestException.ValidationErrors
                };
                break;
            case NotFoundException NotFound:
                statusCode = HttpStatusCode.NotFound;
                problem = new CustomValidationProblemDetails
                {
                    Title = NotFound.Message,
                    Status = (int)statusCode,
                    Type = nameof(NotFoundException),
                    Detail = NotFound.InnerException?.Message,
                };
                break;
            default:
                problem = new CustomValidationProblemDetails
                {
                    Title = ex.Message,
                    Status = (int)statusCode,
                    Type = nameof(HttpStatusCode.InternalServerError),
                    Detail = ex.StackTrace,
                };
                break;
        }

        httpContext.Response.StatusCode = (int)statusCode;
        await httpContext.Response.WriteAsJsonAsync(problem);
    }
    #endregion
}
