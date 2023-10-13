using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Portfolio.Clean.BlazorUI.Contracts.Helpers;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Components.Common;

public partial class PortfolioNavbar
{

    #region Attributes & Accessors

    private string displaySidebar = string.Empty;
    private string aboutList = string.Empty;
    [Inject]
    public ILanguage Language { get; set; }
    private ILanguageContainerService LanguageContainer { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        displaySidebar = "none";
        aboutList = "none";

        LanguageContainer = Language.GetResourceFile();
        await Language.SetLanguageSavedInBrowser();

    }

    private void DisplaySideBar()
	{
        if(displaySidebar == "none")
        {
            displaySidebar = "flex";
        }
        else
        {
            displaySidebar = "none";
        }
    }

    private void AboutDropdown()
    {
        if (aboutList == "none")
        {
            aboutList = "flex";
        }
        else
        {
            aboutList = "none";
        }
    }

    #endregion
}
