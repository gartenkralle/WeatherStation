using Sensor;
using System;
using WeatherStation.Model.Interfaces.SensorAbstraction;

namespace WeatherStation.SensorAbstraction
{
    public class PressureSensorAbstraction : IPressureSensorAbstraction
    {
        private readonly Helper.Hardware hardware;
        public event Action<ValueType> Changed;

        public double Data
        {
            get
            {
                return PressureSensor.Data;
            }
        }

        public PressureSensorAbstraction(int pollingIntervall)
        {
            hardware = new Helper.Hardware();
            hardware.Poll(() => PressureSensor.Data, PressureChanged, pollingIntervall);
        }

        private void PressureChanged(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
