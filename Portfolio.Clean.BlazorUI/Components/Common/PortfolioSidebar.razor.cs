﻿using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Components.Common;

public partial class PortfolioSidebar
{

    #region Attributes & Accessors

    [Parameter]
    public string Sidebar { get; set; }
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
        Sidebar = "none";
        aboutList = "none";

        ActualLanguage = await JS.InvokeAsync<string>("localStorage.getItem", "language");

        if (!String.IsNullOrEmpty(ActualLanguage))
        {
            LanguageContainer.SetLanguage(CultureInfo.GetCultureInfo(ActualLanguage));

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
