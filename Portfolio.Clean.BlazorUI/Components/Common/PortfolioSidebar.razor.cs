namespace Portfolio.Clean.BlazorUI.Components.Common;

public partial class PortfolioSidebar
{

    #region Attributes & Accessors

    private string projectsList = string.Empty;
    private string aboutList = string.Empty;
    
    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override void OnInitialized()
    {
        projectsList = "none";
        aboutList = "none";
    }

    private void ProjectDropdown()
	{
        if(projectsList == "none")
        {
            projectsList = "block";
        }
        else
        {
            projectsList = "none";
        }
    }

    private void AboutDropdown()
    {
        if (aboutList == "none")
        {
            aboutList = "block";
        }
        else
        {
            aboutList = "none";
        }
    }

    #endregion
}
