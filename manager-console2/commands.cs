using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_console
{
    class commands
    {
        public void commandlist()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------Normal Features--------");
            Console.WriteLine("commands - shows the list of all commands");
            Console.WriteLine("twitch - opens twitch in browser with specific channel name");
            Console.WriteLine("clear- clears the console");
            Console.WriteLine("-----------------------------\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------Windows Features-------");
            Console.WriteLine("defender off - disables the windos defender permanent(restart required)");
            Console.WriteLine("defender on - reactivates the defender");
            Console.WriteLine("autoupdate off - disabled windows content updates");
            Console.WriteLine("autoupdate on - re-enables windows content updates");
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
