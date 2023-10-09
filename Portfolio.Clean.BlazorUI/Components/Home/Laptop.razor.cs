using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Reflection;

namespace Portfolio.Clean.BlazorUI.Components.Home;

public partial class Laptop
{

    #region Attributes & Accessors
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
	public string ZIndex { get; set; } = string.Empty;
	#endregion

	#region Constructors

	#endregion

	#region Methods

	#endregion
}