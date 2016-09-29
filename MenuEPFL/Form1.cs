using System;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MenuEPFL
{
    public partial class Main : Form
    {
        static string menusUrl = "https://menus.epfl.ch/cgi-bin/rssMenus";
        static Dictionary<string, Dictionary<string, string>> _restMenu;

        public Main()
        {
            InitializeComponent();
            //_restMenu = new Dictionary<string, List<string>>();
            _restMenu = new Dictionary<string, Dictionary<string, string>>();
        }

        public static List<RssNews> Read(string url)
        {
            var webClient = new WebClient();

            string result = repareRss (webClient.DownloadString(url));

            XDocument document = XDocument.Parse(result);

            return (from descendant in document.Descendants("item")
                    select new RssNews()
                    {
                        Description = descendant.Element("description").Value,
                        Title = descendant.Element("title").Value
                    }).ToList();
        }

        private static string repareRss(string v)
        {

            return Mono.Web.HttpUtility.HtmlDecode(v);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<RssNews> menus = Read(menusUrl);
            for (int i = 0; i < menus.Count; i++)
            {
                var resto = menus[i].Title.Split(':')[0];
                var menuTitle = menus[i].Title.Split(':')[1];
                var menu = menus[i].Description;
                if (!_restMenu.ContainsKey(resto))
                {
                    _restMenu.Add(resto, new Dictionary<string, string>());

                }
                _restMenu[resto].Add(menuTitle,menu);

            }
            selectRestaurant.Items.AddRange(_restMenu.Keys.OrderBy(x => x).ToArray<string>());
        }

        private void selectRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class RssNews
    {
        public string Title;
        public string PublicationDate;
        public string Description;
    }

 
}

