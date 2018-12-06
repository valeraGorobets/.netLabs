using System;

namespace lab6_inner_classes
{
    public class Computer
    {
        public class Ram
        {
            private int amount;
            private string type;

            public int Amount { get => amount; set => amount = value; }
            public string Type { get => type; set => type = value; }

            public Ram(int amount, string type)
            {
                Amount = amount;
                Type = type;
            }

            public string GenerateReport()
            {
                return $"{this.amount}GB of {this.type} onboard memory";
            }
        }

        public enum OSName { Windows, MacOS, Linux, Other };
        public class OperatingSystem
        {
            private OSName operatingSystemName;

            public OSName OperatingSystemName { get => operatingSystemName; set => operatingSystemName = value; }

            public OperatingSystem(OSName osName)
            {
                OperatingSystemName = osName;
            }

            public string GenerateReport()
            {
                return $"OS {this.operatingSystemName}";
            }
        }

        public class Processor
        {
            private string name;
            private int cores;
            private double clockFrequency;

            public string Name { get => name; set => name = value; }
            public int Cores { get => cores; set => cores = value; }
            public double ClockFrequency { get => clockFrequency; set => clockFrequency = value; }

            public Processor(string name, int cores, double clockFrequency)
            {
                Name = name;
                Cores = cores;
                ClockFrequency = clockFrequency;
            }

            public string GenerateReport()
            {
                return $"Processor {this.clockFrequency}GHz {this.cores} cores {this.name}";
            }

        }

        public OSName computerRequired;
        public OperatingSystem operatingSystem;
        public Ram ram;
        public Processor processor;
        public Computer(OSName computerRequired)
        {
            this.computerRequired = computerRequired;
            this.operatingSystem = new OperatingSystem(computerRequired);
            this.CalculateSpecs();
        }

        private void CalculateSpecs()
        {
            switch (this.computerRequired)
            {
                case OSName.Windows:
                    this.ram = new Ram(16, "DDR4");
                    this.processor = new Processor("Intel Core i7 7700HQ", 4, 3.8);
                    break;
                case OSName.MacOS:
                    this.ram = new Ram(32, "DDR4");
                    this.processor = new Processor("Intel Core i9", 6, 4.3);
                    break;
                case OSName.Linux:
                    this.ram = new Ram(8, "DDR4");
                    this.processor = new Processor("Intel Core i5 7200U", 2, 3.1);
                    break;
                default:
                    this.ram = new Ram(4, "DDR3");
                    this.processor = new Processor("Intel Core i3", 2, 3);
                    break;
            }
        }

        public string GetPreferableConfig()
        {
            return $"" +
                $"{this.operatingSystem.GenerateReport()}, " +
                $"{this.ram.GenerateReport()}, " +
                $"{this.processor.GenerateReport()}"; ;
        }
    }
}
