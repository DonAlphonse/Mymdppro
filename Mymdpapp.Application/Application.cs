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

        public void DelWebSite(WebSite webSite)
        {
            if (!webSite.Url.StartsWith("www"))
                throw new System.Exception("Error format");
            int indexToRemove = -1;
            for(int i = 0; i < WebSites.Count; i++)
            {
                if (webSite.Url.Equals(WebSites[i].Url))
                    indexToRemove=i;
            }

            Console.WriteLine("indexToRemove ="+ indexToRemove);
            if (indexToRemove > -1)
            {
                WebSites.RemoveAt(indexToRemove);
                Console.WriteLine("RemoveAt utile");
            }

            //return webSites;
            
        }
    }
}
