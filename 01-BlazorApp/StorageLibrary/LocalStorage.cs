using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace StorageLibrary
{
    public class LocalStorage
    {
        public static async ValueTask<T> GetAsync<T>(IJSRuntime jSRuntime, string key)
        {
            var item = await jSRuntime.InvokeAsync<T>("blazorLocalStorage.get", key);
            return item;
        }

        public static async ValueTask SetAsync(IJSRuntime jSRuntime, string key, object value)
        {
            await jSRuntime.InvokeVoidAsync("blazorLocalStorage.set", key, value);
        }
    }
}