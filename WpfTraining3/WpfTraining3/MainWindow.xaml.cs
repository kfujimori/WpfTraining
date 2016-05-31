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

namespace WpfTraining3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // calendar 1
            this.calendar.BlackoutDates.AddDatesInPast();
            this.calendar.BlackoutDates.Add(
                new CalendarDateRange(
                    DateTime.Today.AddDays(1),
                    DateTime.Today.AddDays(4)));

            // calendar 2
            this.calendar2.DisplayDateStart = DateTime.Now.AddDays(-5);
            this.calendar2.DisplayDateEnd = DateTime.Now.AddMonths(1).AddDays(-1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click");
            var selected = string.Join(Environment.NewLine,
                this.calendar.SelectedDates.Select(d => d.ToString()));
            MessageBox.Show(selected);
        }

        private void hoge(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("mousedown");
            MessageBox.Show(this.calendar.SelectedDate.ToString());
        }

        private void calendar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("MouseLeftButtonDown");
            MessageBox.Show(this.calendar.SelectedDate.ToString());
        }

        private void calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("MouseDoubleClick");
            MessageBox.Show(this.calendar.SelectedDate.ToString());
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DatePicker_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
