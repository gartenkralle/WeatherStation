using System;
using WeatherStation.Controller;
using WeatherStation.DataAccess;
using WeatherStation.Model;
using WeatherStation.Output.ConsoleOutput;
using WeatherStation.View;

namespace Program.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureDataAccess(100)));
            PressureController pressure = new PressureController(new PressureModel(new PressureDataAccess(100)));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumidityDataAccess(100)));

            temperature.Display(new TemperatureView(new ConsoleOutput(0, "Temperature")));
            pressure.Display(new PressureView(new ConsoleOutput(1, "Pressure")));
            humidity.Display(new HumidityView(new ConsoleOutput(2, "Humidity")));

            Console.ReadKey();
        }
    }
}
