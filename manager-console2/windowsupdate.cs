using Microsoft.Win32;
using System;
namespace Manager_console

{
    internal class windowsupdate
    { 
        commands cl = new commands();
        public void off()
        {
            //RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows", true);
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows", true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Trying to create subkey...");
            try
            {
                rk = rk.CreateSubKey("WindowsUpdate");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("subkeay created at " + rk.ToString());
                rk.Close();
                RegistryKey rk2 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("setting value at " + rk2.ToString());
                rk2.SetValue("AU", 2);
                rk2.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("successfully set to 'notify before download'");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("now trying to disable the whole auto update (beta)");
                RegistryKey rk3 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true);
                try
                {
                    Console.WriteLine("writing key....");
                    Console.ForegroundColor = ConsoleColor.Green;
                    rk3 = rk3.CreateSubKey("AU");
                    rk3.SetValue("NoAutoUpdate", 1);
                    Console.WriteLine("successfully disabled the auto update");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!- Restart your Pc now -!");
                    Console.ForegroundColor = ConsoleColor.White;/
                }
                catch(Exception ex3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error: " + ex3);
                    Console.ReadKey();
                    Console.Clear();
                    cl.commandlist();
                }
               
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ReadKey();
                Console.Clear();
                cl.commandlist();
                    
               
            }
        }

        public void on()
        {
            //RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows", true);
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows", true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Trying to create subkey...");
            try
            {
                rk = rk.CreateSubKey("WindowsUpdate");
                Console.ForegroundColor = ConsoleColor.Green;
                rk.Close();
                RegistryKey rk2 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("setting value at " + rk2.ToString());
                rk2.SetValue("AU", 3);
                rk2.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("successfully set to 'On'");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("now trying to enable the whole auto update (beta)");
                RegistryKey rk3 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true);
                try
                {
                    Console.WriteLine("Testing delete key now");
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (rk3 != null && rk3.Name == "AU")
                    {
                        rk3.DeleteSubKey("AU");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("key not found , your autoupdate is already enabled");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    
                    Console.WriteLine("key should be deleted now");
                    rk3.Close();
                    /*Console.WriteLine("writing key....");
                    Console.ForegroundColor = ConsoleColor.Green;
                    //testing later normaly dont need rk3 = rk3.CreateSubKey("AU");
                    rk3.SetValue("NoAutoUpdate", 0);
                    Console.WriteLine("successfully enabled the auto update");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!- Restart your Pc now -!");*/
                }
                catch (Exception ex3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error: " + ex3);
                    Console.ReadKey();
                    Console.Clear();
                    cl.commandlist();
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ReadKey();
                Console.Clear();
                cl.commandlist();


            }
        }
    }
}