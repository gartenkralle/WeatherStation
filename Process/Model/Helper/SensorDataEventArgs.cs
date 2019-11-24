using System;
using WeatherStation.Controller.Interfaces.Helper;

namespace WeatherStation.Model
{
    public class SensorDataEventArgs : AbstractSensorDataEventArgs
    {
        public SensorDataEventArgs(ValueType value)
        {
            Value = value;
        }

        public override ValueType Value { get; }
    }
}
