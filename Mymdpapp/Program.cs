// See https://aka.ms/new-console-template for more information

using Mymdpapp.Application;
using Mymdpapp.Infrastructure;
using System.IO;


Application monApp = new Application();
DbContext myDb = new DbContext();
List<WebSite> CleanedWebSites = new List<WebSite>();


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
{
    Console.WriteLine(webSite.Url);
    
}

CleanedWebSites = monApp.GetWebSites();
Console.WriteLine("Fais du nettoyage");
buffer = Console.ReadLine();

while (buffer != "aye")
{
    WebSite webSiteToDel = new WebSite() { Url = buffer };
    /*CleanedWebSites =*/ monApp.DelWebSite(webSiteToDel);
    Console.WriteLine("Site nettoyé");

    Console.WriteLine("Fais du nettoyage");
    buffer = Console.ReadLine();
}

foreach (WebSite webSite in monApp.GetWebSites())
{
    Console.WriteLine(webSite.Url);

}

var filename = "C:\\Users\\aymer\\Documents\\Perso\\Mymdppro\\Mymdpapp.Infrastructure\\Default.txt";

myDb.SaveToFile(monApp.GetWebSites(), filename);
