namespace EventFlow.Models;

public class PublishEventRequest
{
    public string EventType { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
}