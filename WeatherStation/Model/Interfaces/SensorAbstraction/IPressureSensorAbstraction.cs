using System;

namespace WeatherStation.SensorAbstraction.Interfaces.SensorAbstraction
{
    public interface IPressureSensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
