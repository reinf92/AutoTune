using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace AutoTune_v2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Play play;

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            play = new Play(this);
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            ItemCount.IsEnabled = false;
            ItemLevel.IsEnabled = false;

            play.Run();        
        }

        private void Btn_Stop_Click(object sender, RoutedEventArgs e)
        {            
            ItemCount.IsEnabled = true;
            ItemLevel.IsEnabled = true;
            Progress.Content = "Current Progress : Stand by..";

            play.Abort();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            play.Abort();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
