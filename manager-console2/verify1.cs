using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace Manager_console

{
    internal class verify1
    {
        
        public string Getstring(string pcn)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            try
            {
                
                Console.WriteLine("Read licenz , please wait..");
                WebClient wb = new WebClient();
                wb.Proxy = null;
                Stream stream = wb.OpenRead("https://pastebin.com/raw/7WWYAT7K");
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                pcn = content;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            sw1.Stop();
            float neededtime = sw1.ElapsedMilliseconds / 1000;
            Console.WriteLine("Time elapsed for getting string: " + neededtime+ "seconds");
            return pcn;
            
        }
        public void verify()
        {
            string opcn = Getstring("");
            string pcn;
            pcn = System.Environment.MachineName.ToString();
            Console.WriteLine(pcn);
            if (opcn.Contains(pcn))
            {
                string un;
                string pw;
                Console.WriteLine("login now...");
                Console.WriteLine("User");
                un = Console.ReadLine();
                Console.WriteLine("Password");
                Console.ForegroundColor = ConsoleColor.Black;
                pw = Console.ReadLine();
                if (un == "admin" && pw == "root")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("successfully logged in");
                    commands runcommand = new commands();
                    runcommand.commandlist();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong username or password");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    verify();
                }


            }
            else
            {
                Console.WriteLine("your not allowed to use this program");
                Console.ReadKey();
                System.Environment.Exit(0x1338);
            }
        }
    }
}