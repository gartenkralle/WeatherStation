using System;
using WeatherStation.Controller.Interfaces.Helper;

namespace WeatherStation.Model.Interfaces.DataAccess
{
    public interface ISensorDataAccess
    {
        event EventHandler<AbstractSensorDataEventArgs> Changed;

        double Data { get; }
    }
}
