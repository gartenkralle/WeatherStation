using System;
using WeatherStation.Shared.Model;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface IHumidityDataAccess
    {
        event EventHandler<SensorDataEventArgs> Changed;

        double Data { get; }
    }
}
