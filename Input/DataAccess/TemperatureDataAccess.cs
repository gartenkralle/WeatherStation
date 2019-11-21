using Sensor;
using System;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.DataAccess
{
    public class TemperatureDataAccess : ITemperatureDataAccess
    {
        private readonly Helper.Hardware hardware;
        public event Action<ValueType> Changed;

        public double Data
        {
            get
            {
                return TemperatureSensor.Data;
            }
        }

        public TemperatureDataAccess(int pollingIntervall)
        {
            hardware = new Helper.Hardware();
            hardware.Poll(() => TemperatureSensor.Data, TemperatureChanged, pollingIntervall);
        }

        private void TemperatureChanged(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
