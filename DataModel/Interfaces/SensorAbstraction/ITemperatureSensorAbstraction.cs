using System;

namespace WeatherStation.Model.Interfaces.SensorAbstraction
{
    public interface ITemperatureSensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
