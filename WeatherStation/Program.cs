using System;
using WeatherStation.View;
using WeatherStation.BusinessLogic;
using WeatherStation.Model;
using WeatherStation.HardwareAbstraction;

namespace WeatherStation
{
    class Program
    {
        static void Main()
        {
            WeatherController controller = new WeatherController(new Humidity(new HumiditySensorAbstraction()), new Temperature(new TemperatureSensorAbstraction()), new Pressure(new PressureSensorAbstraction()));
            controller.Display(new MainView(new Output.Console()));

            Console.ReadKey();
        }
    }
}
