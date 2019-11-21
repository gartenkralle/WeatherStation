using System;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface IHumidityDataAccess
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
