using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sentry;
using System;

public class HomeController : Controller
{
    private readonly IHub _sentryHub;

    public HomeController(IHub sentryHub) => _sentryHub = sentryHub;

    [HttpGet("/person/{id}")]
    public IActionResult Person(string id)
    {
        var childSpan = _sentryHub.GetSpan()?.StartChild("additional-work");
        try
        {
            // Do the work that gets measured.

            childSpan?.Finish(SpanStatus.Ok);
        }
        catch (Exception e)
        {
            childSpan?.Finish(e);
            throw;
        }

        return Ok("ok");
    }
}
