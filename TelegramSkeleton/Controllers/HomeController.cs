using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TelegramSkeleton.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private static readonly string[] Descriptions = new[]
        {
            "Developer", "Optimist", "Dreamer"
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public HomepageMessages Get()
        {
            var rng = new Random();
            return new HomepageMessages
            {
                Date = DateTime.Now,
                Summary = "I am " + Descriptions[rng.Next(Descriptions.Length)] + "!"
            };
        }
    }
}