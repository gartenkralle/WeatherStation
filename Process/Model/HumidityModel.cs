using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.Model
{
    public class HumidityModel : IHumidityModel
    {
        private readonly IHumidityDataAccess humidity;

        public HumidityModel(IHumidityDataAccess humidity)
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
