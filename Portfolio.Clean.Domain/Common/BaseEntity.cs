using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain.Common;
/// <summary>
/// Composed of entities' common properties
/// </summary>
public abstract class BaseEntity
{
    #region Attributes & Accessors
    public int Id { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? LastUpdate { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
