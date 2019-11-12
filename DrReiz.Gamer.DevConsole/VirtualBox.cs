﻿using NitroBolt.CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrReiz.Gamer.DevConsole
{
    public static class VirtualBoxBrowser
    {
        [CommandLine("--virtualbox")]
        public static void Execute()
        {

            var virtualbox = new BlueStacks.VirtualBox();

            //new BlueStacks.IMachine

            //var virtualbox = new VirtualBox.VirtualBox();

            Console.WriteLine(virtualbox.HomeFolder);
            Console.WriteLine(virtualbox.Host.OperatingSystem);
            Console.WriteLine(virtualbox.APIVersion);
            foreach (BlueStacks.IMedium disk in virtualbox.HardDisks)
                Console.WriteLine(disk.Name);

            var machines = virtualbox.Machines;
            var machine = (BlueStacks.IMachine)machines.GetValue(0);
            Console.WriteLine(machine.Name);
            Console.WriteLine(machine.LogFolder);

            //foreach (BlueStacks.IMachine machine in machines)
            //    Console.WriteLine(machine.Name);
        }
    }
}