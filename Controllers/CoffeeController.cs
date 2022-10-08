using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("coffee")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("lover")]
        public string Get()
        {
            return "I like coffee!";
        }
        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            if (name == null || name == "latte") return new Coffee() { Name = "latte", Id = -1 };
            return new Coffee() { Name = name, Id = GetUniqueId(name) };
        }
        static int GetUniqueId(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input.ToLower());
            int result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                result += data[i];
            }
            return result;
        }
    }
}
