using ClassLibrary1;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Data
{
    public class XmlHanterare
    {
        public static List<string> newLista = new List<string>();
        public static List<string> kategoriLista = new List<String>();
        public List<String> hamtaLista()
        {
            return newLista;
        }
        public List<String> hamtaKategori()
        {
            return kategoriLista;
        }

        public void AddNew(string namn, string url, string category, string interval)
        {
            using(var client = new WebClient())
            {
                client.DownloadFile(url, Directory.GetCurrentDirectory() + @"\" + category + @"\" + namn + ".xml");
                client.Dispose();
            }
        }

        public List<Category> GetAllCategories()
        {
            var path = Directory.GetCurrentDirectory();
            var folders = Directory.GetDirectories(path);
            List<Category> categories = new List<Category>();
            foreach(var folder in folders)
            {
                var info = new DirectoryInfo(folder);
                categories.Add(new Category() { Title = info.Name, Path = folder, Podcasts = GetAllPodcastsInCategory(folder) });
            }
            return categories;
        }

        public List<Podcast> GetAllPodcastsInCategory(string categoryPath)
        {
            var files = Directory.GetFiles(categoryPath);
            List<Podcast> podcasts = new List<Podcast>();
            foreach(var file in files)
            {
                var info = new FileInfo(file);
                podcasts.Add(new Podcast() { Title = info.Name, Path = file, Episodes = GetAllEpisodesInPodcast(file) });
            }
            return podcasts;
        }

        public List<Episode> GetAllEpisodesInPodcast(string podcastPath)
        {
            var reader = XmlReader.Create(podcastPath);
            var feed = SyndicationFeed.Load(reader);
            var episodes = new List<Episode>();

            foreach (var item in feed.Items)
            {
                var episode = new Episode();
                episode.Title = item.Title.Text;
                foreach(var link in item.Links) //Hämta ut sökvägen till mp3-filen
                {
                    if(link.Uri.OriginalString.EndsWith(".mp3")) //kolla om länken är till en mp3-fil
                    {
                        episode.Url = link.Uri.OriginalString;
                    }
                    episodes.Add(episode);
                }
            }
            return episodes;
        }
        public void laggTillNy(string namn, string url, string category, string interval)
        {
            Rss method = new Rss();
            XmlDocument doc = method.fetchDocument(url);
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + namn + @".xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            int i = 0;

            XmlWriter xmlOut = XmlWriter.Create(path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("channel");
            xmlOut.WriteElementString("interval", interval);
            xmlOut.WriteElementString("url", url);
            xmlOut.WriteElementString("lastSync", DateTime.Now.ToString());
            foreach (XmlNode item
               in doc.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
                var description = item.SelectSingleNode("description");
                var enclosure = item.SelectSingleNode("enclosure/@url");

                xmlOut.WriteStartElement("item");

                xmlOut.WriteAttributeString("ID", "pod" + i);

                if (description.InnerText.Equals(""))
                {
                    xmlOut.WriteElementString("description", "Unfortunately, no description is available.");
                }
                else
                {
                    xmlOut.WriteElementString("description", description.InnerText);
                }

                xmlOut.WriteElementString("title", title.InnerText);
                xmlOut.WriteElementString("enclosure", enclosure.InnerText);
                xmlOut.WriteElementString("status", "Unlistened");

                xmlOut.WriteEndElement();
                i++;
            }

            xmlOut.WriteEndDocument();
            xmlOut.Close();
        }
    }
}