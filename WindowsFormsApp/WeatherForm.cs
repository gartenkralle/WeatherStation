using System;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.SensorAbstraction;
using WeatherStation.View;
using WeatherStation.WinFormsOutput;

namespace WindowsFormsApp
{
    public partial class WeatherForm : System.Windows.Forms.Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureSensorAbstraction()));
            PressureController pressure = new PressureController(new PressureModel(new PressureSensorAbstraction()));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumiditySensorAbstraction()));

            temperature.Display(new TemperatureView(new ConcreteOutput(tbTemperature)));
            pressure.Display(new PressureView(new ConcreteOutput(tbPressure)));
            humidity.Display(new HumidityView(new ConcreteOutput(tbHumidity)));
        }
    }
}
