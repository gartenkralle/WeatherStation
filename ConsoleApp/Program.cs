using System;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.SensorAbstraction;
using WeatherStation.Output;
using WeatherStation.View.Console;

namespace WeatherStation
{
    class Program
    {
        static void Main()
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureSensorAbstraction()));
            PressureController pressure = new PressureController(new PressureModel(new PressureSensorAbstraction()));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumiditySensorAbstraction()));

            temperature.Display(new TemperatureView(new ConsoleOutput()));
            pressure.Display(new PressureView(new ConsoleOutput()));
            humidity.Display(new HumidityView(new ConsoleOutput()));

            Console.ReadKey();
        }
    }
}
