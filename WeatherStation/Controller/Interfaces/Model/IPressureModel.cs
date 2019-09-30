using System;

namespace WeatherStation.Controller.Interfaces.Model
{
    public interface IPressureModel
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}