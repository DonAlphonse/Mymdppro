using System.Collections.Generic;
using Mymdpapp.Infrastructure;

namespace Mymdpapp.Application
{
    public class Application
    {
        private List<WebSite> WebSites = new List<WebSite>();

        public void AddWebSite(WebSite webSite)
        {
            if (!webSite.Url.StartsWith("www"))
                throw new System.Exception("Error format");
            WebSites.Add(webSite);
        }

        public List<WebSite> GetWebSites()
        {
            return WebSites;
        }

        public void SaveToDatabase()
        {

        }

        public void RefreshFromDatabase()
        {

        }
    }
}
