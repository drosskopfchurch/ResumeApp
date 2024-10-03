using System.Dynamic;
using Microsoft.AspNetCore.Components;

public class AppEventService<T>
{
    private T value;
    public T Value { get => value; }
    private List<EventCallback<T>> EventCallbacks = new List<EventCallback<T>>();
    public void Subscribe(EventCallback<T> callback)
    {
        if (EventCallbacks.Contains(callback)) return;
        EventCallbacks.Add(callback);
    }
    public void Unsubscribe(EventCallback<T> callback)
    {
        if (!EventCallbacks.Contains(callback)) return;
        EventCallbacks.Remove(callback);
    }
    public async Task SetAsync(T value)
    {
        try
        {
            this.value = value;
            await Task.WhenAll(EventCallbacks.Select(c => c.InvokeAsync(value)));
        }
        catch { }
    }

}