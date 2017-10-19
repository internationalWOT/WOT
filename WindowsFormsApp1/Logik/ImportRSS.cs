using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Logik
{
    class ImportRSS
    {

    }

    var reader = XmlReader.Create("http://api.sr.se/api/rss/program/4912");
    var feed = SyndicationFeed.Load(reader);

    string s = "";
        foreach (SyndicationItem i in feed.Items)
        {
            s += i.Title.Text + "<br />" + i.Summary.Text + "<br />" + i.PublishDate.ToString() + "<br />";
            foreach (SyndicationElementExtension extension in i.ElementExtensions)
            {
                XElement ele = extension.GetObject<XElement>();
    s += ele.Name + " :: " + ele.Value + "<br />";
            }
s += "<hr />";
        }
        return s;
}
