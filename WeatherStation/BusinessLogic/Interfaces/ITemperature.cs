using System;

namespace WeatherStation.BusinessLogic.Interfaces
{
    public interface ITemperature
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}