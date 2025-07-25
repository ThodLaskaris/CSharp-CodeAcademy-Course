using System;

class Program
{
    interface IDevice
    {
        void DeviceModel();  // μέθοδος χωρίς παράμετρο για εμφάνιση του μοντέλου
        void PrintInfo();
    }

    public class Device : IDevice
    {
        public string DeviceName { get; set; }
        public int DeviceModelNumber { get; set; }  // property για τον αριθμό μοντέλου

        // Constructor που δέχεται όνομα και μοντέλο
        public Device(string name, int model)
        {
            DeviceName = name;
            DeviceModelNumber = model;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The device name is {DeviceName}");
        }

        // Υλοποίηση της μεθόδου DeviceModel από το interface
        public void DeviceModel()
        {
            Console.WriteLine($"Device model number is: {DeviceModelNumber}");
        }
    }

    static void Main(string[] args)
    {
        // Δημιουργείς το αντικείμενο περνώντας όνομα και μοντέλο
        Device myDevice = new("Device0131", 123);

        myDevice.PrintInfo();
        myDevice.DeviceModel();

        Console.WriteLine("Hello World!");
    }
}
