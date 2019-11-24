using Hardware.Sensor;
using System;
using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.DataAccess
{
    public class PressureDataAccess : IPressureDataAccess
    {
        private readonly Helper.Hardware hardware;
        public event EventHandler<AbstractSensorDataEventArgs> Changed;

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

        private void PressureChanged(object sender, AbstractSensorDataEventArgs data)
        {
            Changed?.Invoke(sender, data);
        }
    }
}
