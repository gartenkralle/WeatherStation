using Hardware.Sensor;
using System;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.DataAccess
{
    public class HumidityDataAccess : IHumidityDataAccess
    {
        private readonly Helper.Hardware hardware;

        public event Action<ValueType> Changed;

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

        private void Humidity_Changed(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
