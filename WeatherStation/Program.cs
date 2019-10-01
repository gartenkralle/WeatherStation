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
            ShowWeather();
            //ShowTemperature();
            //ShowPressure();
            //ShowHumidity();

            Console.ReadKey();
        }

        static void ShowWeather()
        {
            WeatherController weather = new WeatherController(
                new HumidityModel(new HumiditySensorAbstraction()),
                new TemperatureModel(new TemperatureSensorAbstraction()),
                new PressureModel(new PressureSensorAbstraction()));

            weather.Display(new MainView(new Output.ConsoleOutput()));
        }

        static void ShowTemperature()
        {
            TemperatureController temperature = new TemperatureController(
                new TemperatureModel(new TemperatureSensorAbstraction()));

            temperature.Display(new TemperatureView(new Output.ConsoleOutput()));
        }

        static void ShowPressure()
        {
            PressureController pressure = new PressureController(
                new PressureModel(new PressureSensorAbstraction()));

            pressure.Display(new PressureView(new Output.ConsoleOutput()));
        }

        static void ShowHumidity()
        {
            HumidityController temperature = new HumidityController(
                new HumidityModel(new HumiditySensorAbstraction()));

            temperature.Display(new HumidityView(new Output.ConsoleOutput()));
        }
    }
}
