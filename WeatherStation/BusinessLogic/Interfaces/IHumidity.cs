using System;

namespace WeatherStation.BusinessLogic
{
    public interface IHumidity
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}