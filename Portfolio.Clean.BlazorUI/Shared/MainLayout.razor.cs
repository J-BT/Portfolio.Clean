namespace Portfolio.Clean.BlazorUI.Shared;

public partial class MainLayout
{

    #region Attributes & Accessors
    bool isLoaded;

    #endregion

    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(4000); // TODO actual initialization job
        isLoaded = true;
    }
    #endregion
}