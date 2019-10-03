using System;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.SensorAbstraction;
using WeatherStation.View;
using WeatherStation.WinFormsOutput;

namespace WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureSensorAbstraction()));
            PressureController pressure = new PressureController(new PressureModel(new PressureSensorAbstraction()));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumiditySensorAbstraction()));

            temperature.Display(new TemperatureView(new ControlOutput(tbTemperature)));
            pressure.Display(new PressureView(new ControlOutput(tbPressure)));
            humidity.Display(new HumidityView(new ControlOutput(tbHumidity)));
        }
    }
}
