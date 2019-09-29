using System;

namespace WeatherStation.BusinessLogic.Interfaces
{
    public interface IHumidity
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}