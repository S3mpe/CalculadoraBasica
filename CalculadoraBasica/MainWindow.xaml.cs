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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int operando1 = 0;
        private int operando2 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ActivarBotonCalcular()
        {
            CalcularButton.IsEnabled = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Operando1TextBlock.Text, out operando1) && int.TryParse(Operando2extBlock.Text, out operando2))
            {
                switch (OperadorTextBlock.Text)
                {
                    case "+":
                        ResultadoTextBlock.Text = (operando1 + operando2).ToString();
                        break;
                    case "-":
                        ResultadoTextBlock.Text = (operando1 - operando2).ToString();
                        break;
                    case "*":
                        ResultadoTextBlock.Text = (operando1 * operando2).ToString();
                        break;
                    case "/":
                        if (operando2 != 0)
                        {
                            ResultadoTextBlock.Text = (operando1 / operando2).ToString();
                        }
                        else
                            ResultadoTextBlock.Text = "Infinito";
                        break;
                    default:
                        MessageBox.Show("El operador no es correcto.");
                        break;
                }
            }
            else
                MessageBox.Show("Se ha producido un error en los operando.");
        }

        private void OperadorTextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (OperadorTextBlock.Text)
            {
                case "+":
                    ActivarBotonCalcular();
                    break;
                case "-":
                    ActivarBotonCalcular();
                    break;
                case "*":
                    ActivarBotonCalcular();
                    break;
                case "/":
                    ActivarBotonCalcular();
                    break;
                default:
                    CalcularButton.IsEnabled = false;
                    break;
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            OperadorTextBlock.Clear();
            Operando1TextBlock.Clear();
            Operando2extBlock.Clear();
            ResultadoTextBlock.Clear();
        }
    }
}
