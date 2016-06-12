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

namespace WpfTraining_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var items = Enumerable.Range(1, 10)
                .Select(i => new Person() { Name = "ほげ" + i, Age = i + 20 })
                .ToList();

            this.comboBox.ItemsSource = items;
            this.comboBoxEditable.ItemsSource = items;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TabControl1.Items.Add(new TabItem()
            {
                Header = "added tab"
            });
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            TabControl1.Items.Remove(TabControl1.Items.GetItemAt(TabControl1.SelectedIndex));
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.textBlock.Text = "on";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.textBlock.Text = "off";
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            this.textBlock.Text = "others";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            this.textBlockSelected.Text = radioButton.Content.ToString();
        }
    }
}
