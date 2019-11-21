using System;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.DataAccess;
using WeatherStation.View;
using WeatherStation.WinFormsOutput;

namespace Program.WindowsFormsApp
{
    public partial class WeatherForm : System.Windows.Forms.Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureDataAccess(100)));
            PressureController pressure = new PressureController(new PressureModel(new PressureDataAccess(100)));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumidityDataAccess(100)));

            temperature.Display(new TemperatureView(new WinFormsOutput(tbTemperature)));
            pressure.Display(new PressureView(new WinFormsOutput(tbPressure)));
            humidity.Display(new HumidityView(new WinFormsOutput(tbHumidity)));
        }
    }
}
