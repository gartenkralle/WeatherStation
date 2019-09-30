using WeatherStation.Controller.Interfaces.Model;
using WeatherStation.Controller.Interfaces.View;

namespace WeatherStation.Controller
{
    public class PressureController
    {
        private readonly IPressureModel pressure;

        public PressureController(IPressureModel pressure)
        {
            this.pressure = pressure;
        }

        public void Display(IPressureView report)
        {
            report.Display(pressure);
        }
    }
}
