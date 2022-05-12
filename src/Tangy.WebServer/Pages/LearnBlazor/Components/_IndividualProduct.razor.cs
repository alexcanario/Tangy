using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using Tangy.Domain.Models;

namespace Tangy.WebServer.Pages.LearnBlazor.Components
{
    public partial class _IndividualProduct
    {
        [Parameter]
        public Product Product { get; set; }

        [Parameter]
        public EventCallback<bool> OnFavoriteUpdated { get; set; }

        [Parameter]
        public EventCallback<string> OnProductSelectedChange { get; set; }    

        private async Task FavoriteUpdated(ChangeEventArgs e)
        {
            await OnFavoriteUpdated.InvokeAsync((bool)e.Value);
        }

        private async Task ProductSelectedChange(MouseEventArgs args, string productName)
        {
            await OnProductSelectedChange.InvokeAsync(productName);
        }
    }
}