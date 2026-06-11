namespace EventFlow.Services;

public class EventConsumerService
{
    public string Consume(string message)
    {
        return $"Processed:{message}";
    }

    public bool Validate(string message)
    {
        return !string.IsNullOrWhiteSpace(message);
    }
}