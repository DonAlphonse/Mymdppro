// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Mymdpapp.Applicat;
using Mymdpapp.Infrastructure;
using MySql.EntityFrameworkCore.Extensions;
using System.IO;
using System.Security.Policy;

Application monApp = new Application();
DbContextFile myDb = new DbContextFile();
PasswordsContext myPassDb = new PasswordsContext();
List<WebSite> CleanedWebSites = new List<WebSite>();


Console.WriteLine("Hello, World!");

Console.WriteLine("Ajoute un site");
var buffer = Console.ReadLine();

int i = 0;

string Name;
int Count;

while (buffer != "fin")
{
    WebSite webSite = new WebSite() { Url = buffer };
    monApp.AddWebSite(webSite);

    Websity websity = new Websity
    {
        Website = buffer,
        Id = i++
    };


    Console.WriteLine("Ajoute un autre site");
    buffer = Console.ReadLine();

    myPassDb.Websities.Add(websity);
    myPassDb.SaveChanges();
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

string textSites = myDb.ReadFromFile(filename);
Console.WriteLine(textSites);



Count = myPassDb.Websities.Local.Count();
Console.WriteLine("Depuis la bdd");
Console.WriteLine(Count);
foreach (Websity websity in myPassDb.Websities.Local)
{
    Console.WriteLine("Depuis la bdd2");
    Name = websity.Website.ToString();
    Console.WriteLine(Name);
}


public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
{
    public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddEntityFrameworkMySQL();
        new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection)
            .TryAddCoreServices();
    }
}
