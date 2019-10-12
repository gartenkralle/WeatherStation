using System;
using WeatherStation.ConsoleOutput;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.SensorAbstraction;
using WeatherStation.View;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureSensorAbstraction(100)));
            PressureController pressure = new PressureController(new PressureModel(new PressureSensorAbstraction(100)));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumiditySensorAbstraction(100)));

            temperature.Display(new TemperatureView(new ConsoleOutput(0, "Temperature")));
            pressure.Display(new PressureView(new ConsoleOutput(1, "Pressure")));
            humidity.Display(new HumidityView(new ConsoleOutput(2, "Humidity")));

            Console.ReadKey();
        }
    }
}
