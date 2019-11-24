using System;
using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.Model
{
    public class TemperatureModel : ITemperatureModel
    {
        private readonly ISensorDataAccess temperature;

        public TemperatureModel(ISensorDataAccess temperature)
        {
            this.temperature = temperature;
            temperature.Changed += Temperature_Changed;
        }

        public double Data => temperature.Data;

        public event EventHandler<AbstractSensorDataEventArgs> Changed;

        private void Temperature_Changed(object sender, AbstractSensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
