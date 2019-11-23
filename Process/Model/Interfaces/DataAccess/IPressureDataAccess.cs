using System;
using WeatherStation.Shared.Model;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface IPressureDataAccess
    {
        event EventHandler<SensorDataEventArgs> Changed;

        double Data { get; }
    }
}
