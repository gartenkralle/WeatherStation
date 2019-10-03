using System;

namespace WeatherStation.Model.Interfaces.SensorAbstraction
{
    public interface IHumiditySensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
