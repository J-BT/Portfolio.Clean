using Microsoft.AspNetCore.Components;

namespace Portfolio.Clean.BlazorUI.Components.Home;

public partial class ActivityCarousel
{

    #region Attributes & Accessors
    [Parameter]
    public string PositionTop { get; set; } = string.Empty;
    [Parameter]
    public string PositionLeft { get; set; } = string.Empty;
	[Parameter]
	public string CarouselWidth { get; set; } = string.Empty;
	[Parameter]
	public string CarouselHeight { get; set; } = string.Empty;
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
