using Microsoft.AspNetCore.Mvc;

namespace day1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocationAPI : Controller
    {
        [HttpPost(Name = "LLocationInfo")]
        public IActionResult WeatherPost([FromBody] LocationRequest request)
        {
            if (!OpenWeather.StationDictionary.TryGetClosestStation(request.Lat, request.Long, out var stationInfo))
            {
                Console.WriteLine("Could not find a station.");
                return NotFound("ERROR");
            }

            var weather = new LocationInfo
            {
                Name = stationInfo.Name,
                ICAO = stationInfo.ICAO,
                Lat = stationInfo.Latitude,
                Long = stationInfo.Longitude,
                Elevation = stationInfo.Elevation,
                Country = stationInfo.Country,
                Region = stationInfo.Region
            };

            return Ok(weather.ToString());
        }

    }
}
