﻿using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Mymdpapp.Infrastructure
{

    public class DbContext
    {
        public DbContext() { }

        public void SaveToFile(List<WebSite> WebSites, string filename)
        {
            var json = JsonConvert.SerializeObject(WebSites, Formatting.Indented);
            File.WriteAllText(filename, json);
        }

        public string ReadFromFile(string filename)
        {
            //var json = JsonConvert.SerializeObject(WebSites, Formatting.Indented);
            string text = File.ReadAllText(filename);



            return text;
        }

    }
}