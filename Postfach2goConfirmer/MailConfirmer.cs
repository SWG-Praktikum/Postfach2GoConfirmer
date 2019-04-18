using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Postfach2goConfirmer
{
    public class MailConfirmer
    {
        public static bool Confirm(string mailName)
        {
            WebClient wc = new WebClient();
            string htmlCode = wc.DownloadString("https://www.postfach2go.de/?" + mailName + "@briefkasten2go.de");

            string innerMail = htmlCode.Split(new string[] { "id=\"email-list\"" }, StringSplitOptions.None)[1].Split(new string[] { "</main>" }, StringSplitOptions.None)[0];
            MatchCollection matches = Regex.Matches(innerMail, @"(http|ftp|https)://([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])?");

            foreach(Match match in matches)
            {
                var request = (HttpWebRequest)WebRequest.Create(match.Value);
                request.GetResponse();
            }

            if (matches.Count > 0)
                return true;
            return false;
        }
    }
}
