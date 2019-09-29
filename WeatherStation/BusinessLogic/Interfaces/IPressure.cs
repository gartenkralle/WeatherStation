using System;

namespace WeatherStation.BusinessLogic
{
    public interface IPressure
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}