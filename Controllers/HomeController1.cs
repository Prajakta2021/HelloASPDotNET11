using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")] //every path for each action method needs to start with /helloworld.
    public class HomeController1 : Controller
    {
        //GET: <controller>
        [HttpGet]
        
        public IActionResult Index()
        {
            string html = "<form method='post' action ='/helloworld/Welcome'>" +
                "<input type='text' name='name' />" +
                //  "<label for ='language'>Choose a Language:</label>" +
                //  "<input type='select'/>" +
                "<select name='language' >" +

                " <option value='english'>English</option >" +
                "<option value='french'>French</option >" +
                "<option value='hindi'>Hindi</option >" +
                "<option value='spanish'>Spanish</option > " +
                "<option value='italian'>Italian</option >" +
                "</select>" +

                "<input type='submit' value='Greet Me!'/>" +

                "</form>";

            return Content(html, "text/html");
        }
        //GET/hello/welcome
        // [HttpGet]
        //[Route("/helloworld/welcome/{name?}")]//name is used as a path variable and passed the value "Tillie"
        //curly braces specifies that we want to use the value of name, not the word “name”.
        // [HttpGet("welcome/{name?}")]
        //  [HttpPost]         
        // public IActionResult Welcome(string name = "World") //we want to provide a value to name in case the user navigates to a URL without a query string.
        //we give the argument, name, a value of "World". We do this to make name an optional parameter.
        // Optional parameters are designated with a default value "World"
        // {
        //      return Content("<h1>Welcome to my app, " + name+ "!<h1>", "text/html");

        // }

       // [HttpGet("Welcome/{name?}/{language?}")]
        [HttpPost ("welcome")]
        [Route("/helloworld/welcome")]
        public IActionResult Welcome(  string name = "World", string language = "English")
        {
            return Content(CreateMessage(name, language), "text/html");

        }

        public static string CreateMessage(string name, string language)
        {
            string greeting ="";
            if (language == "english")
            {
                greeting = "Hello";
            }
            else if (language == "french")
            {
                greeting = "Bonjour";
            }
            else if (language == "hindi")
            {
                greeting = "Namste";
            }
            else if (language == "spanish")
            {
                greeting = "Hola";
            }
            else if (language == "italian")
            {
                greeting = "Ciao";
            }
           
            return "<h1>" + greeting + ", " + name + "!" + "</h1>";
        }
    }
}

