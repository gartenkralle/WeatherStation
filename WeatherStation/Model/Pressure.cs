using System;
using WeatherStation.BusinessLogic;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.Model
{
    public class Pressure : IPressure
    {
        private readonly IPressureSensorAbstraction pressure;

        public Pressure(IPressureSensorAbstraction pressure)
        {
            this.pressure = pressure;
            pressure.Changed += Pressure_Changed; ;
        }

        public double Data => pressure.Data;

        public event Action<ValueType> Changed;

        private void Pressure_Changed(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
