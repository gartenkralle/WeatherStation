using Hardware.Sensor;
using System;
using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.DataAccess
{
    public class HumidityDataAccess : ISensorDataAccess
    {
        private readonly Helper.Hardware hardware;

        public event EventHandler<AbstractSensorDataEventArgs> Changed;

        public double Data
        {
            get
            {
                return HumiditySensor.Data;
            }
        }

        public HumidityDataAccess(int pollingIntervall)
        {
            hardware = new Helper.Hardware();
            hardware.Poll(() => HumiditySensor.Data, Humidity_Changed, pollingIntervall);
        }

        private void Humidity_Changed(object sender, AbstractSensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
