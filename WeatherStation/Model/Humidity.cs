using System;
using WeatherStation.BusinessLogic;
using WeatherStation.HardwareAbstraction.Interfaces;

namespace WeatherStation.Model
{
    public class Humidity : IHumidity
    {
        private readonly IHumiditySensorAbstraction humidity;

        public Humidity(IHumiditySensorAbstraction humidity)
        {
            this.humidity = humidity;
            humidity.Changed += Humidity_Changed; ;
        }

        public double Data => humidity.Data;

        public event Action<ValueType> Changed;

        private void Humidity_Changed(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
