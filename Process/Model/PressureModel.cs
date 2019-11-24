using System;
using WeatherStation.Controller.Interfaces.Helper;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;

namespace WeatherStation.Model
{
    public class PressureModel : IPressureModel
    {
        private readonly ISensorDataAccess pressure;

        public PressureModel(ISensorDataAccess pressure)
        {
            this.pressure = pressure;
            pressure.Changed += Pressure_Changed; ;
        }

        public double Data => pressure.Data;

        public event EventHandler<AbstractSensorDataEventArgs> Changed;

        private void Pressure_Changed(object sender, AbstractSensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
