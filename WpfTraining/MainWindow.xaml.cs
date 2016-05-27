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
using System.Windows.Controls.Primitives;
using System.Collections.ObjectModel;

namespace WpfTraining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new ObservableCollection<Person>(
                Enumerable.Range(1, 100).Select(i => new Person
                {
                    Name = "あああ" + i,
                    Gender = i % 2 == 0 ? Gender.men : Gender.women,
                    Age = 20 + i % 50,
                    AuthMember = i % 5 == 0
                })
                
            );
            dataGrid.ItemsSource = data;
            dataGrid.AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            dataGrid2.ItemsSource = data;


            var data3 = new ObservableCollection<Person>(
                Enumerable.Range(1, 100).Select(i => new Person
                {
                    Name = "あああ" + i,
                    Gender = i % 2 == 0 ? Gender.men : Gender.women,
                    Age = 20 + i % 50,
                    AuthMember = i % 5 == 0
                })

            );
            dataGrid3.ItemsSource = data3;
        }

        private int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            button.Content = string.Format("{0}回", ++count);
        }

        private int count2 = 0;
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (RepeatButton)sender;
            button.Content = string.Format("{0}回", ++count2);
        }

        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Name":
                    e.Column.Header = "name";
                    e.Column.DisplayIndex = 0;
                    break;
                case "Age":
                    e.Column.Header = "age";
                    e.Column.DisplayIndex = 1;
                    break;
                case "Gender":
                    e.Cancel = true;
                    break;
                case "AuthMember":
                    e.Column.Header = "auth";
                    e.Column.DisplayIndex = 2;
                    break;
                default:
                    throw new InvalidOperationException();


            }
        }
    }
}
