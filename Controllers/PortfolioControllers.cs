using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers     //be sure to use your own project's namespace!
{
    public class PortfolioControllers : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        // [HttpGet]       //type of request
        // [Route("")]     //associated route string (exclude the leading /)
        [HttpGet("")]      // Both upper lines can be written in one line
        public string Index()
        {
            return "This is my index";
        }

        [HttpGet("projects")]
        // GET requests to "localhost:5000/about" go here
        public string Project()
        {
            // Method body
            return "These are my projects";
        }

        [HttpGet("contact/{name}")]
        // GET requests to "localhost:5000/about" go here
        public string contacts(string name)
        {
            // Method body
            return $"This is my contacts and my name is {name}";
        }

    }
}

