using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using FileIO;

namespace day1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JsonToString : ControllerBase
    {
        [HttpPost(Name = "JsonToString")]
        public bool Post([FromBody] JsonElement request)
        {
            try
            {
                FileIO.FileIO.WriteFile(request.ToString());
                Console.WriteLine(request.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
