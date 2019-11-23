using Hardware.Sensor;
using System;
using WeatherStation.Model.Interfaces.DataAccess;
using WeatherStation.Shared.Model;

namespace WeatherStation.DataAccess
{
    public class PressureDataAccess : IPressureDataAccess
    {
        private readonly Helper.Hardware hardware;
        public event EventHandler<SensorDataEventArgs> Changed;

        public double Data
        {
            get
            {
                return PressureSensor.Data;
            }
        }

        public PressureDataAccess(int pollingIntervall)
        {
            hardware = new Helper.Hardware();
            hardware.Poll(() => PressureSensor.Data, PressureChanged, pollingIntervall);
        }

        private void PressureChanged(object sender, SensorDataEventArgs data)
        {
            Changed?.Invoke(sender, data);
        }
    }
}
