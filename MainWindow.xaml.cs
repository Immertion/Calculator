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
using Calculator;


namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Operand operand1 = null;
        Operand operand2 = null;
        Operator op = null;
        string buffer = "0";
        string buf_up = "";


        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add_digit(object sender, RoutedEventArgs e)
        {
            if (buffer == "0")
            {
                buffer = "";
            }
            var button = sender as Button;
            var atr = button.Tag;
            buffer += atr;
            Text.Content = buffer;
        }
        public void sumarize()
        {
            if (op != null)
            {
                operand2 =  new Operand(Convert.ToInt16(buffer));
            }
            else
            {
                operand1 = new Operand(Convert.ToInt16(buffer));
            }
        }
        private void sum_click(object sender, RoutedEventArgs e)
        {
            Plus plus = new Plus();
            sumarize();
            buf_up += buffer;
            if (op != null)
            {
                operand1 = op.Calculate(operand1, operand2);
                operand2.value = 0;
                buffer = "0";
                Text.Content = operand1.value.ToString();
            }
            else
            {
                buffer = "0";
                Text.Content = buffer;
            }
            op = plus;
            buf_up += '+';
            behind_text.Content = buf_up;
        }

        private void division_click(object sender, RoutedEventArgs e)
        {
            Division division = new Division();
            sumarize();
            buf_up += buffer;
            if (op != null)
            {
                operand1 = op.Calculate(operand1, operand2);
                operand2.value = 0;
                buffer = "0";
                Text.Content = operand1.value.ToString(); 
            }
            else
            {
                buffer = "0";
                Text.Content = buffer;
            }
            op = division;
            buf_up += '/';
            behind_text.Content = buf_up;

        }

        private void minus_click(object sender, RoutedEventArgs e)
        {
            Minus minus = new Minus();
            sumarize();
            buf_up += buffer;
            if (op != null)
            {
                operand1 = op.Calculate(operand1, operand2);
                operand2.value = 0;
                buffer = "0";
                Text.Content = operand1.value.ToString(); 
            }
            else
            {
                buffer = "0";
                Text.Content = buffer;
            }
            op = minus;
            buf_up += '-';
            behind_text.Content = buf_up;


        }
        private void myltiply_click(object sender, RoutedEventArgs e)
        {
            Myltiply myltiply = new Myltiply();
            sumarize();
            buf_up += buffer;
            if (op != null)
            {
                operand1 = op.Calculate(operand1, operand2);
                operand2.value = 0;
                buffer = "0";
                Text.Content = operand1.value.ToString();
            }
            else
            {
                buffer = "0";
                Text.Content = buffer;
            }
            op = myltiply;
            buf_up += '*';
            behind_text.Content = buf_up;


        }
        private void result_click(object sender, RoutedEventArgs e)
        {
            sumarize();
            operand1 = op.Calculate(operand1, operand2);
            buffer = operand1.value.ToString();
            op = null;
            buf_up = "";
            behind_text.Content = buf_up;
            Text.Content = buffer;
        }

        private void delete_last_click(object sender, RoutedEventArgs e)
        {
            if (buffer.Length > 1)
            {
                buffer = buffer.Remove(buffer.Length - 1);
                Text.Content = buffer;
            }
            else
            {
                buffer = "0";
                Text.Content = buffer;
            }
        }
    }
}
