using System;

namespace WeatherStation.Controller.Interfaces.Model
{
    public interface ITemperatureModel
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}