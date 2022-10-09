using Microsoft.AspNetCore.Mvc;
using BlazorApp1.Shared.Models;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : ControllerBase
    {
        private static readonly IEnumerable<Activity> _activities = new List<Activity>()
        {
            new Activity()
            {
                    Name = "Drop In/Let Out",
                    Description = "We stop by check on your animals, let them out etc.",
            },
            new Activity()
            {
                    Name = "Walk",
                    Description = "We come by and walk your animal per instructions",
            },
            new Activity()
            {
                    Name = "Boarding",
                    Description = "We take your animals overnight",
            },
            new Activity()
            {
                    Name = "House Sitting",
                    Description = "We watch your house/animals and stay with them",
            },
            new Activity()
            {
                    Name = "Day Care",
                    Description = "dayCare",
            },
        };

        private readonly ILogger<ActivityController> _logger;

        public ActivityController(ILogger<ActivityController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Activity> Get()
        {
            return _activities.ToArray();
        }
    }
}
