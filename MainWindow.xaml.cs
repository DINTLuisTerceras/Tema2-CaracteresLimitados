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

namespace T2_ej4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void caracteresTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            contadorTextBlock.Text = caracteresTextBox.Text.Length.ToString();

            if (int.Parse(contadorTextBlock.Text) >= 140) {
                caracteresTextBox.IsReadOnly = true;
            }
        }
    }
}
