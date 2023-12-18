using System.Threading.Tasks;
using Microsoft.JSInterop;
using BlazorUIWebAssembly.Shared;

namespace BlazorUIWebAssembly.Services
{
    public class ClipboardService
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly Popup popup = new();

        public ClipboardService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public ValueTask WriteTextAsync(string text)
        {
            return _jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
        public async Task CopyToClipboard(string text)
        {
            try
            {
                await WriteTextAsync(text);
            }
            catch
            {
                popup.Show("Failed to copy to clipboard", "Error");
            }
        }
    }
}
