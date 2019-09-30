using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.SensorAbstraction.Interfaces.SensorAbstraction;

namespace WeatherStation.Model
{
    public class HumidityModel : ITemperatureModel
    {
        private readonly IHumiditySensorAbstraction humidity;

        public HumidityModel(IHumiditySensorAbstraction humidity)
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
