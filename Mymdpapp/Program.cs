// See https://aka.ms/new-console-template for more information

using Mymdpapp.Infra;

Application monApp = new Application();


Console.WriteLine("Hello, World!");

Console.WriteLine("Ajoute un site");
var buffer = Console.ReadLine();

while (buffer != "fin")
{
    WebSite webSite = new WebSite() { Url = buffer };
    monApp.AddWebSite(webSite);

    Console.WriteLine("Ajoute un autre site");
    buffer = Console.ReadLine();
}

foreach (WebSite webSite in monApp.GetWebSites())
    Console.WriteLine(webSite.Url);