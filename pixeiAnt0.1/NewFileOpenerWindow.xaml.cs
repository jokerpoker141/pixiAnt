using pixeiAnt0._1.Drawing_Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pixeiAnt0._1
{
    /// <summary>
    /// Interaction logic for NewFileOpenerWindow.xaml
    /// </summary>
    

    public partial class NewFileOpenerWindow : Window
    {
        public int WindowWitdh { get; set; }
        public int WindowHeigth { get; set; } 

        public NewFileOpenerWindow()
        {

            InitializeComponent();
            DataContext = this;

        }

        private void StartNewWindow(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(WindowWitdh.ToString());
            //MessageBox.Show(WindowHeigth.ToString());

            MainDrawingWindow mainDrawingWindow = new MainDrawingWindow();
            mainDrawingWindow.Show();
            Close();
        }

    }
}
