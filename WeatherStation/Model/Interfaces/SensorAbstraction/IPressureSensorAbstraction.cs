using System;

namespace WeatherStation.Model.Interfaces.SensorAbstraction
{
    public interface IPressureSensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
