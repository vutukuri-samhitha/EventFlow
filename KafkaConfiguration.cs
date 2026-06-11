namespace EventFlow.Configuration;

public class KafkaConfiguration
{
    public string BootstrapServers { get; set; } = "localhost:9092";
    public string TopicName { get; set; } = "eventflow-topic";
    public string ConsumerGroup { get; set; } = "eventflow-group";
}