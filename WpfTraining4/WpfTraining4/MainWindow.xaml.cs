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
using Microsoft.Win32;

namespace WpfTraining4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var source = Enumerable.Range(1, 10)
                .Select(i => new Person { Name = "P" + i, Age = 10 + i });
            this.tabControl.ItemsSource = source;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            if( slider != null)
            {
                double rounded = Math.Round(slider.Value, 1);
                slider.Value = rounded;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "open file";
            dialog.Filter = "all files(*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                this.textBlockFileName.Text = System.IO.Path.GetFileName(dialog.FileName.ToString());
            }
            else
            {
                this.textBlockFileName.Text = "canceled";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = "save file";
            dialog.Filter = "all files(*.*)|*.*";
            if(dialog.ShowDialog() == true)
            {
                this.textBlockFileName.Text = System.IO.Path.GetFileName(dialog.FileName.ToString());
            }
            else
            {
                this.textBlockFileName.Text = "canceled";
            }

        }
    }
}
