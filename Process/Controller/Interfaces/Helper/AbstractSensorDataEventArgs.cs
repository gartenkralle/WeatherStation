using System;

namespace WeatherStation.Controller.Interfaces.Helper
{
    public abstract class AbstractSensorDataEventArgs : EventArgs
    {
        public abstract ValueType Value { get; }
    }
}
