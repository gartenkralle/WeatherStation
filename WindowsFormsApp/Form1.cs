using System;
using System.Windows.Forms;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.Output;
using WeatherStation.SensorAbstraction;
using WeatherStation.View.Gui;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureSensorAbstraction()));
            PressureController pressure = new PressureController(new PressureModel(new PressureSensorAbstraction()));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumiditySensorAbstraction()));

            temperature.Display(new TemperatureView(new WinFormsControlOutput(tbTemperature)));
            pressure.Display(new PressureView(new WinFormsControlOutput(tbPressure)));
            humidity.Display(new HumidityView(new WinFormsControlOutput(tbHumidity)));
        }
    }
}
