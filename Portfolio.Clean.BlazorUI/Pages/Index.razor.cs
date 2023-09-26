namespace Portfolio.Clean.BlazorUI.Pages;

public partial class Index
{

    #region Attributes & Accessors
    private string TitleJob { get; set; } = string.Empty;
    public string LaptopTypingWords { get; set; } = string.Empty;
    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        TitleJob = "Solutions Logicielles";
        LaptopTypingWords = "[\"Applications web\", \"Logiciels\", \"Sites vitrines\"]";

        await base.OnInitializedAsync();
    }

    #endregion
}
