using System;
using WeatherStation.View;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.SensorAbstraction;

namespace WeatherStation
{
    class Program
    {
        static void Main()
        {
            WeatherController weather = new WeatherController(
                new HumidityModel(new HumiditySensorAbstraction()),
                new TemperatureModel(new TemperatureSensorAbstraction()),
                new PressureModel(new PressureSensorAbstraction()));

            weather.Display(new MainView(new Output.ConsoleOutput()));

            Console.ReadKey();
        }
    }
}
