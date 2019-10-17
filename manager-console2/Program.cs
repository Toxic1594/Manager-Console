using System;
using System.IO;
using Manager_console;
using System.Diagnostics;
namespace Manager_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string getcommand;

            Console.WriteLine("Windows Manager by Exptixone startet successfully\n");
            Console.ForegroundColor = ConsoleColor.White;
            commands commandliste = new commands();
            twitch twitchcommand = new twitch();
            verify1 verify = new verify1();
            windows_defender windowsdefender = new windows_defender();
            windowsupdate autoupdate = new windowsupdate();
            //verify.verify();
            
            while (true)
            {
                getcommand = Console.ReadLine();
                switch (getcommand)
                {
                    case "commands"://shows commands
                        commandliste.commandlist();
                        break;

                    case "twitch"://opens twitch with user specific channel name
                        twitchcommand.twitchcommand();
                        break;

                    case "clear"://u know...
                        Console.Clear();
                        break;

                    case "defender off"://disables the defender over the registry
                        windowsdefender.defenderoff();
                        break;

                    case "defender on"://deletes the registry key to re-enable the defender
                        windowsdefender.defenderon();
                        break;

                    case "autoupdate off"://adds 2 registry keys to disable AU first one is for notify 2nd on for complete disable
                        autoupdate.off();
                        break;

                    case "autoupdate on"://like off but needs a "rework" later
                        autoupdate.on();
                        break;


                    default:
                        Console.WriteLine("Unknown command");
                        break;

                }
                System.Threading.Thread.Sleep(200);
            }









        }
    }
}
