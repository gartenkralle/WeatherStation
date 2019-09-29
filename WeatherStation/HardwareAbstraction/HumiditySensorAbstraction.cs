using System;
using WeatherStation.Hardware;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.HardwareAbstraction
{
    internal class HumiditySensorAbstraction : IHumiditySensorAbstraction
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

        public HumiditySensorAbstraction()
        {
            hardware = new Helper.Hardware();
            hardware.Poll(() => HumiditySensor.Data, Humidity_Changed);
        }

        private void Humidity_Changed(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
