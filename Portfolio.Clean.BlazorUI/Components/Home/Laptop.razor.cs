using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Reflection;

namespace Portfolio.Clean.BlazorUI.Components.Home;

public partial class Laptop
{

    #region Attributes & Accessors
    private List<string> LaptopText { get; set; } = new();
    private string TypingText { get; set; } = string.Empty;

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    private IJSObjectReference? module;
    #endregion

    #region Constructors

    #endregion

    #region Methods

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        
        if (firstRender)
        {
            module = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./Components/Home/Laptop.razor.js");

            await module.InvokeVoidAsync("exampleFunction1");
        }

    }
    //protected override async Task OnInitializedAsync()
    //{
    //    //await base.OnInitializedAsync().ConfigureAwait(false);
    //    //Thread typingThread = new Thread(new ThreadStart(Typing));

    //}

    //private static void Typing()
    //{
    //    while (true)
    //    {
    //        var texts = new List<string>
    //        { "Applications web", "Logiciels", "Sites vitrines"};
    //        var laptop = new Laptop(texts);

    //        laptop.TypeText();

    //        Thread.Sleep(5000);


    //    }
    //}

    //private async void TypeText()
    //{
    //    foreach (string text in LaptopText)
    //    {
    //        TypingText += text;
    //        await Task.Delay(1000);
    //        //foreach (char letter in text)
    //        //{
    //        //    TypingText += letter;
    //        //    await Task.Delay(100);
    //        //}
    //    }
    //}
    #endregion
}
