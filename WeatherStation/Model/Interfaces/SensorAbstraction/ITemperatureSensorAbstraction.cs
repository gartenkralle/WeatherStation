using System;

namespace WeatherStation.SensorAbstraction.Interfaces.SensorAbstraction
{
    public interface ITemperatureSensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
