using System.Windows;
using testFlight.ViewModels;

namespace testFlight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService(typeof(MainWindowViewModel));
            Closing += MainWindow_Closing;    
        }

        private void MainWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            //(DataContext as MainWindowViewModel).Save();
        }

        
    }
}
