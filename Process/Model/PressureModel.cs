using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;
using WeatherStation.Shared.Model;

namespace WeatherStation.Model
{
    public class PressureModel : IPressureModel
    {
        private readonly IPressureDataAccess pressure;

        public PressureModel(IPressureDataAccess pressure)
        {
            this.pressure = pressure;
            pressure.Changed += Pressure_Changed; ;
        }

        public double Data => pressure.Data;

        public event EventHandler<SensorDataEventArgs> Changed;

        private void Pressure_Changed(object sender, SensorDataEventArgs sensorData)
        {
            Changed?.Invoke(sender, sensorData);
        }
    }
}
