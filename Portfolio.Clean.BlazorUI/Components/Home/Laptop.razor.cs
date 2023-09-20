using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Reflection;

namespace Portfolio.Clean.BlazorUI.Components.Home;

public partial class Laptop
{

    #region Attributes & Accessors

    [Inject]
    public IJSRuntime? JSRuntime { get; set; }

    private IJSObjectReference? module { get; set; }

    public string TypingWords { get; set; } = string.Empty;
    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override void OnInitialized()
    {
        TypingWords = "[\"Applications web\", \"Logiciels\", \"Sites vitrines\"]";
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            module = await JSRuntime!.InvokeAsync<IJSObjectReference>("import", "./Components/Home/Laptop.razor.js");
            await module.InvokeVoidAsync("typeOnLaptop");
        }
    }
    #endregion
}
