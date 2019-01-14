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

namespace DesktopAufräumer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        List<String> type = new List<string>();

        public MainWindow()
        {
           InitializeComponent();           
        }


        private void AppyButton_Click(object sender, RoutedEventArgs e)
        {
            DesktopItems items = new DesktopItems(type);

            ListDesktopItems.Text = String.Join(Environment.NewLine, items.readItems());

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void JpgCheckbox_Click(object sender, RoutedEventArgs e)
        {
            if (jpgCheckbox.IsChecked == true)
            {
                if (type.Contains("*.jpg") == true)
                {

                }
                else
                {
                    type.Add("*.jpg");
                }
            }
            else
            {
                if (type.Contains("*.jpg") == true)
                {
                    type.Remove("*.jpg");
                }
                else
                {
                }
            }
        }

        private void Mp4Checkbox_Click(object sender, RoutedEventArgs e)
        {
            if (mp4Checkbox.IsChecked == true)
            {
                if (type.Contains("*.mp4") == true)
                {

                }
                else
                {
                    type.Add("*.mp4");
                }
            }
            else
            {
                if (type.Contains("*.mp4") == true)
                {
                    type.Remove("*.mp4");
                }
                else
                {
                }
            }
        }

        private void FolderCheckbox_Click(object sender, RoutedEventArgs e)
        {
           // type.Add("*.jpg");
        }

        private void TxtCheckbox_Click(object sender, RoutedEventArgs e)
        {
            if (txtCheckbox.IsChecked == true)
            {
                if (type.Contains("*.txt") == true)
                {
                }
                else
                {
                 type.Add("*.txt");
                }                
            }
            else
            {
                if (type.Contains("*.txt") == true) {
                    type.Remove("*.txt");
                }
                else
                {
                }
            }
        }

        private void PngCheckbox_Click(object sender, RoutedEventArgs e)
        {
            if (pngCheckbox.IsChecked == true)
            {
                if (type.Contains("*.png") == true)
                {
                }
                else
                {
                    type.Add("*.png");
                }
            }
            else
            {
                if (type.Contains("*.png") == true)
                {
                    type.Remove("*.png");
                }
                else
                {
                }
            }
        }

        private void DocxCheckbox_Click(object sender, RoutedEventArgs e)
        {
            if (docxCheckbox.IsChecked == true)
            {
                if (type.Contains("*.docx") == true)
                {
                }
                else
                {
                    type.Add("*.docx");
                }
            }
            else
            {
                if (type.Contains("*.docx") == true)
                {
                    type.Remove("*.docx");
                }
                else
                {
                }
            }
        }

        private void ListDesktopItems_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
