using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Components.Common;

public partial class PortfolioNavbar
{

    #region Attributes & Accessors

    private string displaySidebar = string.Empty;
    private string aboutList = string.Empty;
    [Inject]
    private ILanguageContainerService LanguageContainer { get; set; }
    [Inject]
    public IJSRuntime JS { get; set; }
    public string ActualLanguage { get; set; } = string.Empty;

    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        displaySidebar = "none";
        aboutList = "none";

        ActualLanguage = await JS.InvokeAsync<string>("localStorage.getItem", "language");

        if (!String.IsNullOrEmpty(ActualLanguage))
        {
            LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(ActualLanguage));

        }
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
