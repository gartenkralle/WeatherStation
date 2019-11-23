using Hardware.Sensor;
using System;
using WeatherStation.Model.Interfaces.DataAccess;
using WeatherStation.Shared.Model;

namespace WeatherStation.DataAccess
{
    public class HumidityDataAccess : IHumidityDataAccess
    {
        private readonly Helper.Hardware hardware;

        public event EventHandler<SensorDataEventArgs> Changed;

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

        private void Humidity_Changed(object sender, SensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
