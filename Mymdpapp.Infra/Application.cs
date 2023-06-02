using System.Collections.Generic;

namespace Mymdpapp.Infra
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
