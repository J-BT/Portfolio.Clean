using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Clean.Domain;

public class Technology
{
    #region Attributes & Properties

    public string IdTechno { get; set; } = string.Empty;
    //public string TechnoName { get; set; } = string.Empty; //XML
    public byte[]? TechnoImg { get; set; }
    public DateTime TechnoCreationDate { get; set; }
    public DateTime TechnoLastUpdate { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
