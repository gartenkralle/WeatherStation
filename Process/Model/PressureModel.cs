using System;
using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Model.Interfaces.DataAccess;

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

        public event Action<ValueType> Changed;

        private void Pressure_Changed(ValueType data)
        {
            Changed?.Invoke(data);
        }
    }
}
