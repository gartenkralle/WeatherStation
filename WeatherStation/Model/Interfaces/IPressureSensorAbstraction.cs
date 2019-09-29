using System;

namespace WeatherStation.HardwareAbstraction.Interfaces
{
    public interface IPressureSensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
