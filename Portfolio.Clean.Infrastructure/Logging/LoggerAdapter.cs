using Microsoft.Extensions.Logging;
using Portfolio.Clean.Application.Contracts.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Infrastructure.Logging;

public class LoggerAdapter<T> : IAppLogger<T>
{

    #region Attributes & Accessors
    private readonly ILogger<T> _logger;
    #endregion

    #region Constructors
    public LoggerAdapter(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<T>();
    }
    #endregion

    #region Methods
    public void LogInformation(string message, params object[] args)
    {
        _logger.LogInformation(message, args);
    }

    public void LogWarning(string message, params object[] args)
    {
        _logger.LogWarning(message, args);
    }
    #endregion

}
