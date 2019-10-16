using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_console
{
    class twitch
    {
        public void twitchcommand()
        {
            string twitchname;
            Console.WriteLine("Enter channel name now");
            twitchname = Console.ReadLine();
            var twitchurl = new System.Diagnostics.ProcessStartInfo("http://www.twitch.tv/" + twitchname);
            {
                twitchurl.UseShellExecute = true;
                twitchurl.Verb = "open";
            };
            if (twitchname != "" || twitchname != null)
            {
                System.Diagnostics.Process.Start(twitchurl);
            }
            else
            {
                Console.WriteLine("please enter the channel name of the user u want to visit");
            }
        }

    }
}
