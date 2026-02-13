using WebServer.Server;
using WebServer.Server.Responses;

namespace WebServer.demo
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            new HttpServer(routes => routes
            .MapGet("/", new TextResponse("Hello from the server!"))
            .MapGet("/html", new HtmlResponse("<h1>HTML response</h1>"))
            .MapGet("/Redirect", new RedirectResponse("https://softuni.org/")))
            .Start();
        }
    }
}
