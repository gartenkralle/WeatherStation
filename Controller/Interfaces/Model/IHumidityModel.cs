using System;

namespace WeatherStation.Controller.Interfaces.Model
{
    public interface IHumidityModel
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}