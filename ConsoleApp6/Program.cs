using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor"))
            {
                foreach (ManagementObject currentObj in searcher.Get())
                {
                    Console.WriteLine("----------- Win32_VideoController instance -------");
                    Console.WriteLine("AdapterRAM: {0}", item["AdapterRAM"]);
                    Console.WriteLine("Caption: {0}", item["Caption"].ToString());
                    Console.WriteLine("Description: {0}", item["Description"].ToString());
                    Console.WriteLine("VideoProcessor: {0}", item["VideoProcessor"].ToString());
                    string Adapter = currentObj["AdapterRam"].ToString();
                    Console.WriteLine(Adapter);
                }
            }
        }
    }
}
