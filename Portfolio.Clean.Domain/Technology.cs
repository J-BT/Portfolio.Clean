using Portfolio.Clean.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain;

public class Technology : BaseEntity
{
    #region Attributes & Accessors
    public string TechnoName { get; set; } = string.Empty;
    public byte[]? TechnoImg { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
