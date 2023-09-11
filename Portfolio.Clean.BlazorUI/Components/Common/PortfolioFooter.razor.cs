namespace Portfolio.Clean.BlazorUI.Components.Common;

public partial class PortfolioFooter
{

	#region Attributes & Accessors
	public int Year { get; set; }
    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override void OnInitialized()
    {
        Year = DateTime.Now.Year;
    }
    #endregion
}
