using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{userString}")]

        public string Mumbling(string userString)
        {

            var results = "";
            for (var index = 0; index < userString.Length; index++)
            {
                var upperLetter = userString[index].ToString().ToUpper();
                var lowerLetter = userString[index].ToString().ToLower();
                results += upperLetter;
                for (var i = 0; i < index; i++)
                {
                    results += lowerLetter;
                }
                if (userString.Length - 1 > index)
                {
                    results += "-";
                }

            }
            return results;
        }
    }

}