using System;

namespace WeatherStation.HardwareAbstraction.Interfaces
{
    public interface IHumiditySensorAbstraction
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
