using System;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.HardwareAbstraction
{
    class HumiditySensorAbstraction : IHumiditySensorAbstraction
    {
        private readonly Hardware hardware;

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
            hardware = new Hardware();
            hardware.Poll(() => HumiditySensor.Data, Humidity_Changed);
        }

        private void Humidity_Changed(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
