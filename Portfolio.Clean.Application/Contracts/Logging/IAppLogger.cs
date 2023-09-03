using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Contracts.Logging;

public interface IAppLogger<T>
{

	#region Attributes & Accessors

	#endregion

	#region Constructors

	#endregion

	#region Methods
	void LogInformation(string message, params object[] args);
	void LogWarning(string message, params object[] args);
	#endregion
}
