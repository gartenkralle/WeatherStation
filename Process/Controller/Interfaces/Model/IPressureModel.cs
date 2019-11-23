using System;
using WeatherStation.Shared.Model;

namespace WeatherStation.Controller.Interfaces.Model
{
    public interface IPressureModel
    {
        event EventHandler<SensorDataEventArgs> Changed;

        double Data { get; }
    }
}