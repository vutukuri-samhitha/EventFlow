namespace EventFlow.Services;

public class EventMetricsService
{
    public int PublishedCount { get; private set; }

    public void Increment()
    {
        PublishedCount++;
    }

    public object Snapshot()
    {
        return new { PublishedCount, GeneratedAt = DateTime.UtcNow };
    }
}