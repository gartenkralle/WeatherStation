using System.Windows;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.SensorAbstraction;
using WeatherStation.View;
using WeatherStation.WpfOutput;

namespace Program.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureSensorAbstraction(100)));
            PressureController pressure = new PressureController(new PressureModel(new PressureSensorAbstraction(100)));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumiditySensorAbstraction(100)));
            
            temperature.Display(new TemperatureView(new WpfOutput(Dispatcher, tbTemperature)));
            pressure.Display(new PressureView(new WpfOutput(Dispatcher, tbPressure)));
            humidity.Display(new HumidityView(new WpfOutput(Dispatcher, tbHumidity)));
        }
    }
}
