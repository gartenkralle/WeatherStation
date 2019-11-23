using Hardware.Sensor;
using System;
using WeatherStation.Model.Interfaces.DataAccess;
using WeatherStation.Shared.Model;

namespace WeatherStation.DataAccess
{
    public class TemperatureDataAccess : ITemperatureDataAccess
    {
        private readonly Helper.Hardware hardware;
        public event EventHandler<SensorDataEventArgs> Changed;

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

        private void TemperatureChanged(object sender, SensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
