using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfTraining6
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = (TextBox)sender;
            switch (text.Name)
            {
                case "a":
                    this.textBlock.Text = text.Text + " is input.";
                    break;
                case "b":
                    this.textBloc2.Text = text.Text + " is input.";
                    break;
                case "c":
                    this.textBloc3.Text = text.Text + " is input.";
                    break;
                default:
                    break;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "image |*.jpg; *.jpeg; *.png";
            if (dialog.ShowDialog()!=true)
            {
                return;
            }
            var ms = new MemoryStream();
            using (var s = new FileStream(dialog.FileName, FileMode.Open))
            {
                s.CopyTo(ms);
            }
            ms.Seek(0, SeekOrigin.Begin);
            var bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.StreamSource = ms;
            bmp.EndInit();
            this.image.Source = bmp;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "動画|*.*";
            if (dialog.ShowDialog() != true)
            {
                return;
            }
            var uri = new Uri(dialog.FileName);
            this.mediaElement.Source = uri;
        }
    }
}
