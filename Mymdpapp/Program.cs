// See https://aka.ms/new-console-template for more information

using Mymdpapp.Infra;

List<WebSite> webSites = new List<WebSite>();

Console.WriteLine("Hello, World!");
Console.WriteLine("Ajoute le site 1");
var site1 = Console.ReadLine();
WebSite webSite1 = new WebSite() { Url = site1 };

Console.WriteLine("Ajoute le site 2");
var site2 = Console.ReadLine();
WebSite webSite2 = new WebSite() { Url = site2 };

Console.WriteLine("Ajoute le site 3");
var site3 = Console.ReadLine();
WebSite webSite3 = new WebSite() { Url = site3 };

webSites.Add(webSite1);
webSites.Add(webSite2);
webSites.Add(webSite3);

foreach (WebSite webSite in webSites)
    Console.WriteLine(webSite.Url);