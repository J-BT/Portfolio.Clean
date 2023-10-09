using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Reflection;

namespace Portfolio.Clean.BlazorUI.Components.Home;

public partial class LaptopOld
{

    #region Attributes & Accessors

    [Inject]
    public IJSRuntime? JSRuntime { get; set; }

    private IJSObjectReference? module { get; set; }
    [Parameter]
    public string TypingWords { get; set; } = string.Empty;
	[Parameter]
	public string PositionTop { get; set; } = string.Empty;
	[Parameter]
	public string PositionLeft { get; set; } = string.Empty;
	[Parameter]
	public string Opacity { get; set; } = string.Empty;
	[Parameter]
	public string ContainerWidth { get; set; } = string.Empty;
	[Parameter]
	public string ContainerHeight { get; set; } = string.Empty;
	[Parameter]
	public string LaptopWidth { get; set; } = string.Empty;
	[Parameter]
	public string LaptopHeight { get; set; } = string.Empty;
	[Parameter]
	public string ZIndex { get; set; } = string.Empty;
	#endregion

	#region Constructors

	#endregion

	#region Methods

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