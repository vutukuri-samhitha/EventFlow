namespace EventFlow.Services;

public class EventProducerService
{
    private readonly List<string> _events = new();

    public void Publish(string type, string payload)
    {
        _events.Add($"{type}:{payload}");
    }

    public IEnumerable<string> GetPublished()
    {
        return _events;
    }
}