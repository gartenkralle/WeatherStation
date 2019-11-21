using System;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface IPressureDataAccess
    {
        event Action<ValueType> Changed;

        double Data { get; }
    }
}
