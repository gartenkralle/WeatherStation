using System;
using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.Model
{
    public class HumidityModel : IHumidityModel
    {
        private readonly ISensorDataAccess humidity;

        public HumidityModel(ISensorDataAccess humidity)
        {
            this.humidity = humidity;
            humidity.Changed += Humidity_Changed; ;
        }

        public double Data => humidity.Data;

        public event EventHandler<AbstractSensorDataEventArgs> Changed;

        private void Humidity_Changed(object sender, AbstractSensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
