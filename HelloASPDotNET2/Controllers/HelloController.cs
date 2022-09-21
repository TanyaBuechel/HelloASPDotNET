using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET2.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        //GET: /<controller>/welcome
        [HttpGet]
        [HttpPost("welcome")]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type ='text' name='name' />" +
                "<select name='language'>" + 
                    "<option value=''>--Please choose an option--</option>" +
                    "<option value='english'>English</option>" +
                    "<option value='french'>French</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='japanese'>Japanese</option>" +
                    "<option value='arabic'>Arabic</option>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        public static string CreateMessage(string name, string lanugage)
        {
            if(lanugage == "French")
            {
                return "Bonjour, " + name + "!";
            
            } 
            else if (lanugage == "Spanish")
            {
                return "Hola, " + name + "!";

            }
            else if (lanugage == "Japanese")
            {
                return "Kon'nichiwa, " + name + "!";

            }
            else if (lanugage == "Arabic")
            {
                return "'ahlan, " + name + "!";

            }
            else
            {
                return "Hello, " + name + "!";

            }
        }

        //GET: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!<h1>", "text/html");
        }
    }
}
