using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;
using WeatherStation.Shared.Model;

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

        public event EventHandler<SensorDataEventArgs> Changed;

        private void Humidity_Changed(object sender, SensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
