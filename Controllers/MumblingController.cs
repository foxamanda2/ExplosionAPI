using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{charString}")]

        public string Mumbling(string charString)
        {

            var results = "";
            for (var index = 0; index < charString.Length; index++)
            {
                var upperLetter = charString[index].ToString().ToUpper();
                var lowerLetter = charString[index].ToString().ToLower();
                results += upperLetter;
                for (var i = 0; i < index; i++)
                {
                    results += lowerLetter;
                }
                if (charString.Length - 1 > index)
                {
                    results += "-";
                }

            }
            return results;
        }
    }

}