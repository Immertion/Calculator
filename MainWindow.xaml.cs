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


namespace Calc
{

    public partial class MainWindow : Window
    {
        Operand operand1 = null;
        Operand operand2 = null;
        Base_operator op = null;
        Operand memory_operand = new Operand(0);
        
        string buffer = "0";
        string buf_up = "";
        string history = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void key_use(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.D0)
            {
                check_zero();
                buffer += '0';
                Text.Content = buffer;
            }
            if (e.Key == Key.D1)
            {
                check_zero();
                buffer += '1';
                Text.Content = buffer;
            }
            if (e.Key == Key.D2)
            {
                check_zero();
                buffer += '2';
                Text.Content = buffer;
            }
            if (e.Key == Key.D3)
            {
                check_zero();
                buffer += '3';
                Text.Content = buffer;
            }
            if (e.Key == Key.D4)
            {
                check_zero();
                buffer += '4';
                Text.Content = buffer;
            }
            if (e.Key == Key.D5)
            {
                check_zero();
                buffer += '5';
                Text.Content = buffer;
            }
            if (e.Key == Key.D6)
            {
                check_zero();
                buffer += '6';
                Text.Content = buffer;
            }
            if (e.Key == Key.D7)
            {
                check_zero();
                buffer += '7';
                Text.Content = buffer;
            }
            if (e.Key == Key.D8)
            {
                check_zero();
                buffer += '8';
                Text.Content = buffer;
            }
            if (e.Key == Key.D9)
            {
                check_zero();
                buffer += '9';
                Text.Content = buffer;
            }
            if (e.Key == Key.OemPlus) sum_click(sender, e);
            if (e.Key == Key.OemMinus) minus_click(sender, e);
            if (e.Key == Key.Back) delete_last_click(sender, e);
            if (e.Key == Key.OemPipe) division_click(sender, e);
            if (e.Key == Key.Multiply) myltiply_click(sender, e);
            if (e.Key == Key.OemPeriod) Add_digit(sender, e);
            if (e.Key == Key.Enter) result_click(sender, e);
        }
        private void Add_digit(object sender, RoutedEventArgs e)
        {
            check_zero();
            var button = sender as Button;
            var atr = button.Tag;
            buffer += atr;
            Text.Content = buffer;
        }
        public void check_zero()
        {
            if (buffer == "0")
            {
                buffer = "";
            }
        }
        public void sumarize()
        {
            if (op != null)
            {
                operand2 = new Operand(Convert.ToDouble(buffer));
            }
            else
            {
                operand1 = new Operand(Convert.ToDouble(buffer));
            }
        }
        public void print_operand()
        {
            if (op != null)
            {
                buffer = operand2.value.ToString();
                Text.Content = buffer;
            }
            else
            {
                buffer = operand1.value.ToString();
                Text.Content = buffer;
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
        private void change_sign(object sender, RoutedEventArgs e)
        {
            Sign sign = new Sign();
            sumarize();
            if (op != null)
            {
                operand2 = sign.Calculate(operand2);
            }
            else
            {
                operand1 = sign.Calculate(operand1);
            }
            print_operand();
        }
        private void percent_click(object sender, RoutedEventArgs e)
        {
            Percent percent = new Percent();
            sumarize();
            if (op != null)
            {
                operand2 = percent.Calculate(operand2);
            }
            else
            {
                operand1 = percent.Calculate(operand1);
            }
            print_operand();
        }

        private void reverse_click(object sender, RoutedEventArgs e)
        {
            Reverse reverse = new Reverse();
            sumarize();
            if (op != null)
            {
                operand2 = reverse.Calculate(operand2);
            }
            else
            {
                operand1 = reverse.Calculate(operand1);
            }
            print_operand();
        }

        private void sqrt_click(object sender, RoutedEventArgs e)
        {
            Sqrt sqrt = new Sqrt();
            sumarize();
            if (op != null)
            {
                operand2 = sqrt.Calculate(operand2);
            }
            else
            {
                operand1 = sqrt.Calculate(operand1);
            }
            print_operand();
        }
        private void square_click(object sender, RoutedEventArgs e)
        {
            Square square = new Square();
            sumarize();
            if (op != null)
            {
                operand2 = square.Calculate(operand2);
            }
            else
            {
                operand1 = square.Calculate(operand1);
            }
            print_operand();
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
        private void c_click(object sender, RoutedEventArgs e)
        {
            buffer = "0";
            buf_up = "";
            op = null;
            behind_text.Content = buf_up;
            Text.Content = buffer;
        }
        private void ce_click(object sender, RoutedEventArgs e)
        {
            buffer = "0";
            Text.Content = buffer;
        }
        private void mc_click(object sender, RoutedEventArgs e)
        {
            memory_operand.value = 0;
        }

        private void mr_click(object sender, RoutedEventArgs e)
        {
            buffer = memory_operand.value.ToString();
            Text.Content = buffer;
        }

        private void mplus_click(object sender, RoutedEventArgs e)
        {
            memory_operand.value += Convert.ToDouble(buffer);
        }

        private void mminus_click(object sender, RoutedEventArgs e)
        {
            memory_operand.value -= Convert.ToDouble(buffer);
        }

        private void ms_click(object sender, RoutedEventArgs e)
        {
            memory_operand.value = Convert.ToDouble(buffer);
        }
        private void result_click(object sender, RoutedEventArgs e)
        {
            sumarize();
            history = buf_up + buffer + " = ";
            operand1 = op.Calculate(operand1, operand2);
            buffer = operand1.value.ToString();
            history += buffer;
            his.Items.Add(history);
            op = null;
            buf_up = "";
            history = "";
            behind_text.Content = buf_up;
            Text.Content = buffer;
        }


    }
}
