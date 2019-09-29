using System;

namespace WeatherStation.BusinessLogic.Interfaces
{
    public interface IPressure
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}