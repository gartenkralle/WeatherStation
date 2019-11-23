using System;

namespace WeatherStation.Shared.Model
{
    public class SensorDataEventArgs : EventArgs
    {
        public SensorDataEventArgs(ValueType value)
        {
            Value = value;
        }

        public ValueType Value { get; }
    }
}
