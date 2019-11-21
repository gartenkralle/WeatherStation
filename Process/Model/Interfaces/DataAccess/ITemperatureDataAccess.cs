using System;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface ITemperatureDataAccess
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
