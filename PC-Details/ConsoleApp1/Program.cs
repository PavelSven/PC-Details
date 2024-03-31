﻿using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Monitor();

            }
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        static public void Monitor()
        {
            Computer computer = new Computer
            {
                IsCpuEnabled = true,
/*                IsGpuEnabled = true,
                IsMemoryEnabled = true,
                IsMotherboardEnabled = true,
                IsControllerEnabled = true,
                IsNetworkEnabled = true,
                IsStorageEnabled = true*/
            };

            computer.Open();
            computer.Accept(new UpdateVisitor());

            foreach (IHardware hardware in computer.Hardware)
            {
                /*                Console.WriteLine("Hardware: {0}", hardware.Name);

                                foreach (IHardware subhardware in hardware.SubHardware)
                                {
                                    Console.WriteLine("\tSubhardware: {0}", subhardware.Name);

                                    foreach (ISensor sensor in subhardware.Sensors)
                                    {
                                        Console.WriteLine("\t\tSensor: {0}, value: {1}", sensor.Name, sensor.Value);
                                    }
                                }

                                foreach (ISensor sensor in hardware.Sensors)
                                {
                                    Console.WriteLine("\tSensor: {0}, value: {1}", sensor.Name, sensor.Value);
                                }*/
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                            Console.WriteLine($"{sensor.Name}: {sensor.Value}\n");
                    }
                    
                }
            }

            computer.Close();
        }
    }
}
