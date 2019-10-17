using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Data;
using System.Security.Permissions;
namespace Manager_console
{
    class windows_defender
    {
        public void checkOS()
        {
            string OSv = System.Environment.OSVersion.ToString();
            Console.WriteLine(OSv);
        }






        commands cl = new commands();
        public void defenderoff()
        {
            Console.Clear();
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("writing registry key ...");
            try
            {
                rk.SetValue("DisableAntiSpyware", 1);
                rk.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("#done");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("if your already using an anticheat , this function doesnt works");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!-Your computer needs a restart now , to disable the defender-!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error at : " + ex1);
                Console.ReadKey();
                Console.Clear();
                cl.commandlist();
            }


        }
        public void defenderon()
        {
            Console.Clear();
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("writing registry key ...");
            try
            {
                rk.SetValue("DisableAntiSpyware", 0);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("#done");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!-Your computer needs a restart now ,to re-enable the defender-!");
                Console.ForegroundColor = ConsoleColor.White;
                rk.Close();
            }
            catch (Exception ex2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error at : " + ex2);
                Console.ReadKey();
                Console.Clear();
                cl.commandlist();
            }

        }
    }
}
