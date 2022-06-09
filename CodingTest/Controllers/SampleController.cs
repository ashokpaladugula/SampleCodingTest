using CodingTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace CodingTest.Controllers
{
    [Route("api/sample")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            string path = @"C:\Users\KSTL\source\repos\CodingTest\Sample.json";

            var jsonObject = JsonSerializer.Serialize(user);
            using (var sw = new StreamWriter(path, true)) {
                sw.WriteLine(jsonObject.ToString());
                sw.Close();
            }
            return Ok();
        }
    }
}
