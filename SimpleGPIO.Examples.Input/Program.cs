using SimpleGPIO.Boards;

using var pi = new RaspberryPi();
var button = pi.Pin11;
var led = pi.Pin16;
button.OnPowerOn(() => led.Toggle());

Console.WriteLine("Press any key to exit...");
Console.ReadKey();