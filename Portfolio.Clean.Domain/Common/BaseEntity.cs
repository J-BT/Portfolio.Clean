using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain.Common;

public abstract class BaseEntity
{
    #region Attributes & Accessors
    //[Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? LastUpdate { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
