using Hardware.Sensor;
using System;
using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.DataAccess
{
    public class TemperatureDataAccess : ISensorDataAccess
    {
        private readonly Helper.Hardware hardware;
        public event EventHandler<AbstractSensorDataEventArgs> Changed;

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

        private void TemperatureChanged(object sender, AbstractSensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
