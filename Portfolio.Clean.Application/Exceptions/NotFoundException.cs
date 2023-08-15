using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Application.Exceptions
{
    public class NotFoundException : Exception
    {

        #region Attributes & Accessors

        #endregion

        #region Constructors
        public NotFoundException(string name, object key) 
            : base($"{name} ({key}) was not found")
        {
                
        }
        #endregion

        #region Methods

        #endregion
    }
}
