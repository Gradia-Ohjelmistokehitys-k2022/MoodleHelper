using System.Threading.Tasks;
using Microsoft.JSInterop;
using BlazorUIWebAssembly.Shared;

namespace BlazorUIWebAssembly.Services
{
    public interface IClipboardService
    {
        Task CopyToClipboard(string text);
    }
    public class ClipboardService : IClipboardService
    {
        private readonly IJSRuntime _jsInterop;
        
        public ClipboardService(IJSRuntime jsInterop)
        {
            _jsInterop = jsInterop;
        }
        public async Task CopyToClipboard(string text)
        {
            await _jsInterop.InvokeVoidAsync("navigator.clipboard.writeText");
        }
    }
}
