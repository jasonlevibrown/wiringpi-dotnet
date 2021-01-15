using System;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;

namespace Unosquare.WiringPi.Workbench
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var blinkingPin = Pi.Gpio[17];
            blinkingPin.PinMode = GpioPinDriveMode.Output;
            var isOn = false;
            for (var i = 0; i < 20; i++)
            {
                isOn = !isOn;
                blinkingPin.Write(isOn);
                System.Threading.Thread.Sleep(500);
            }            
        }
    }
}
