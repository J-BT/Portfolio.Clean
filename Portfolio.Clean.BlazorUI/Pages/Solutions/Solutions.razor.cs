using AKSoftware.Localization.MultiLanguages;
using System.Globalization;

namespace Portfolio.Clean.BlazorUI.Pages.Solutions;

public partial class Solutions
{

    #region Attributes & Accessors

    private bool isLoaded = false;
    #endregion


    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {

        isLoaded = true;
        await base.OnInitializedAsync();
    }
    #endregion
}
