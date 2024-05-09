using Microsoft.AspNetCore.Mvc;
using APIprot.Clients;
using APIprot.body;

namespace APIprot.Controllers
{
    [ApiController]
    [Route("controller")]
    public class BodyController : ControllerBase
    {
        private readonly ILogger<BodyController> _logger;
        public BodyController(ILogger<BodyController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public List<Body> BodyPart(string bodyPart)
        {
            Client client = new Client();
            List<Body> exercises = client.GetExercises(bodyPart).Result;
            return exercises;
        }
    }
}
