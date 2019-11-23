using System;
using WeatherStation.Shared.Model;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface ITemperatureDataAccess
    {
        event EventHandler<SensorDataEventArgs> Changed;

        double Data { get; }
    }
}
