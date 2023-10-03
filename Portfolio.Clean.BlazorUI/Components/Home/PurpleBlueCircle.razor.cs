using Microsoft.AspNetCore.Components;

namespace Portfolio.Clean.BlazorUI.Components.Home;

public partial class PurpleBlueCircle
{

    #region Attributes & Accessors
    [Parameter]
    public string PositionTop { get; set; } = string.Empty;
    [Parameter]
    public string PositionLeft { get; set; } = string.Empty;
	[Parameter]
	public string CircleWidth { get; set; } = string.Empty;
	[Parameter]
	public string ZIndex { get; set; } = string.Empty;
	[Parameter]
	public string Opacity { get; set; } = string.Empty;

	#endregion

	#region Constructors

	#endregion

	#region Methods

	#endregion
}
