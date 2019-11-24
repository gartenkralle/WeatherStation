using System;
using WeatherStation.Controller.Interfaces.Helper;

namespace WeatherStation.Controller.Interfaces.Model
{
    public interface ITemperatureModel
    {
        event EventHandler<AbstractSensorDataEventArgs> Changed;

        double Data { get; }
    }
}