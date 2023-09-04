using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Models.Common;

public class ResultObject
{

    #region Attributes & Accessors
    public bool Result { get; }
    public string Description { get; } = string.Empty;
    #endregion

    #region Constructors

    public ResultObject(bool result) 
    {
        Result = result;
    }
    public ResultObject(bool result, string description)
    {
        Result = result;
        Description = description;
    }


    #endregion

    #region Methods

    #endregion
}
