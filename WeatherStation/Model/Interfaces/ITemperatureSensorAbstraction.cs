using System;

namespace WeatherStation.HardwareAbstraction.Interfaces
{
    public interface ITemperatureSensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
