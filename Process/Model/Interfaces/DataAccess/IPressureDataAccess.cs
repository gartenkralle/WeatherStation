using System;
using WeatherStation.Controller.Interfaces.Helper;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface IPressureDataAccess
    {
        event EventHandler<AbstractSensorDataEventArgs> Changed;

        double Data { get; }
    }
}
