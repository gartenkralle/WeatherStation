using System;

namespace WeatherStation.SensorAbstraction.Interfaces.SensorAbstraction
{
    public interface IHumiditySensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
