using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;
using WeatherStation.Shared.Model;

namespace WeatherStation.Model
{
    public class TemperatureModel : ITemperatureModel
    {
        private readonly ITemperatureDataAccess temperature;

        public TemperatureModel(ITemperatureDataAccess temperature)
        {
            this.temperature = temperature;
            temperature.Changed += Temperature_Changed;
        }

        public double Data => temperature.Data;

        public event EventHandler<SensorDataEventArgs> Changed;

        private void Temperature_Changed(object sender, SensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
