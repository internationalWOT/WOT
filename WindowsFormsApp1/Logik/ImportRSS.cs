using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace Logik
{
    public class ImportRSS
    {
        public void Read()
        {

            var reader = XmlReader.Create("http://alexosigge.libsyn.com/rss");
            var feed = SyndicationFeed.Load(reader);

            var titles = new List<string>();
            foreach (SyndicationItem i in feed.Items)
            {
                var title = i.Title.Text;
                titles.Add(title);
            }

            return titles; 

            


        }
    }

    
}

   