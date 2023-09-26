namespace Portfolio.Clean.BlazorUI.Pages.Projects;

public partial class Project
{
    #region Attributes & Accessors
    private string DescriptionTxt { get; set; } = string.Empty;
    private string Technologies { get; set; } = string.Empty;
    #endregion

    #region Constructors

    #endregion

    #region Methods
    protected override async Task OnInitializedAsync()
    {
        DescriptionTxt = "Description du projet";
        Technologies = "Liste des technologies (.NET, angular, etc)";

        await base.OnInitializedAsync();
    }
    #endregion
}
