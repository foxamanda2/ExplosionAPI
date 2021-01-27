using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{numString}")]

        public string Explosion(string numString)
        {

            var results = "";
            for (var index = 0; index < numString.Length; index++)
            {
                var sInt = int.Parse(numString[index].ToString());

                for (var i = 0; i < sInt; i++)
                {
                    results += numString[index];
                }
            }
            return results;
        }
    }
}
