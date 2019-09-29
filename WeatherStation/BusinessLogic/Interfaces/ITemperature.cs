using System;

namespace WeatherStation.BusinessLogic
{
    public interface ITemperature
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}