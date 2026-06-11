using Microsoft.AspNetCore.Mvc;
using EventFlow.Models;
using EventFlow.Services;

namespace EventFlow.Controllers;

[ApiController]
[Route("api/events")]
public class EventController : ControllerBase
{
    private readonly EventProducerService _producer;

    public EventController(EventProducerService producer)
    {
        _producer = producer;
    }

    [HttpPost]
    public IActionResult Publish(PublishEventRequest request)
    {
        _producer.Publish(request.EventType, request.Payload);
        return Accepted();
    }
}