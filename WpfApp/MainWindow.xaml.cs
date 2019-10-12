using System.Threading;
using System.Windows;
using WeatherStation.Controller;
using WeatherStation.Model;
using WeatherStation.SensorAbstraction;
using WeatherStation.View;
using WeatherStation.WpfOutput;

namespace WpfApp
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
            TemperatureController temperature = new TemperatureController(new TemperatureModel(new TemperatureSensorAbstraction()));
            PressureController pressure = new PressureController(new PressureModel(new PressureSensorAbstraction()));
            HumidityController humidity = new HumidityController(new HumidityModel(new HumiditySensorAbstraction()));
            
            temperature.Display(new TemperatureView(new ConcreteOutput(Dispatcher, tbTemperature)));
            pressure.Display(new PressureView(new ConcreteOutput(Dispatcher, tbPressure)));
            humidity.Display(new HumidityView(new ConcreteOutput(Dispatcher, tbHumidity)));
        }
    }
}
