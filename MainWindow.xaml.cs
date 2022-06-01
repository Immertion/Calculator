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
        string history = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void key_use(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D0)
            {
                remove_leading_zero();
                buffer += '0';
                Text.Content = buffer;
            }
            if (e.Key == Key.D1)
            {
                remove_leading_zero();
                buffer += '1';
                Text.Content = buffer;
            }
            if (e.Key == Key.D2)
            {
                remove_leading_zero();
                buffer += '2';
                Text.Content = buffer;
            }
            if (e.Key == Key.D3)
            {
                remove_leading_zero();
                buffer += '3';
                Text.Content = buffer;
            }
            if (e.Key == Key.D4)
            {
                remove_leading_zero();
                buffer += '4';
                Text.Content = buffer;
            }
            if (e.Key == Key.D5)
            {
                remove_leading_zero();
                buffer += '5';
                Text.Content = buffer;
            }
            if (e.Key == Key.D6)
            {
                remove_leading_zero();
                buffer += '6';
                Text.Content = buffer;
            }
            if (e.Key == Key.D7)
            {
                remove_leading_zero();
                buffer += '7';
                Text.Content = buffer;
            }
            if (e.Key == Key.D8)
            {
                remove_leading_zero();
                buffer += '8';
                Text.Content = buffer;
            }
            if (e.Key == Key.D9)
            {
                remove_leading_zero();
                buffer += '9';
                Text.Content = buffer;
            }
            if (e.Key == Key.OemPlus) sum_click(sender, e);
            if (e.Key == Key.OemMinus) minus_click(sender, e);
            if (e.Key == Key.Back) delete_last_click(sender, e);
            if (e.Key == Key.OemPipe) division_click(sender, e);
            if (e.Key == Key.Multiply) myltiply_click(sender, e);
            if (e.Key == Key.OemPeriod) add_digit(sender, e);
            if (e.Key == Key.Enter) result_click(sender, e);
        }
        private void add_digit(object sender, RoutedEventArgs e)
        {
            remove_leading_zero();
            buffer += (sender as Button).Tag;
            Text.Content = buffer;
        }
        public void remove_leading_zero()
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
        public void Calc()
        {
            behind_text.Content += buffer;
            if (op != null)
            {
                operand1 = op.Calculate(operand1, operand2);
                operand2.value = operand1.value;
                buffer = "0";
                Text.Content = operand1.value.ToString();
            }
            else
            {
                buffer = "0";
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
            sumarize();
            Calc();
            op = new Plus();
            behind_text.Content += "+";
        }

        private void division_click(object sender, RoutedEventArgs e)
        {
            sumarize();
            Calc();
            op = new Division();
            behind_text.Content += "/";
        }

        private void minus_click(object sender, RoutedEventArgs e)
        { 
            sumarize();
            Calc();
            op = new Minus();
            behind_text.Content += "-";
        }
        private void myltiply_click(object sender, RoutedEventArgs e)
        {
            sumarize();
            Calc();
            op = new Myltiply();
            behind_text.Content += "*";
        }
        public void calc_single(Additional_operator single_op)
        {
            if (op != null)
            {
                operand2 = single_op.Calculate(operand2);
            }
            else
            {
                operand1 = single_op.Calculate(operand1);
            }
        }
        private void change_sign(object sender, RoutedEventArgs e)
        {
            if (buffer == "0")
            {
                return;
            }
            Sign sign = new Sign();
            sumarize();
            calc_single(sign);
            print_operand();
        }
        private void percent_click(object sender, RoutedEventArgs e)
        {
            Percent percent = new Percent();
            sumarize();
            calc_single(percent);
            print_operand();
        }

        private void reverse_click(object sender, RoutedEventArgs e)
        {
            Reverse reverse = new Reverse();
            sumarize();
            calc_single(reverse);
            print_operand();
        }

        private void sqrt_click(object sender, RoutedEventArgs e)
        {
            Sqrt sqrt = new Sqrt();
            sumarize();
            calc_single(sqrt);
            print_operand();
        }
        private void square_click(object sender, RoutedEventArgs e)
        {
            Square square = new Square();
            sumarize();
            calc_single(square);
            print_operand();
        }
        private void delete_last_click(object sender, RoutedEventArgs e)
        {
            if (buffer.Length > 1)
            {
                buffer = buffer.Remove(buffer.Length - 1);
            }
            else
            {
                buffer = "0";
            }
            Text.Content = buffer;
        }
        private void c_click(object sender, RoutedEventArgs e)
        {
            buffer = "0";
            op = null;
            behind_text.Content = "";
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
            history = behind_text.Content + buffer + " = ";
            operand1 = op.Calculate(operand1, operand2);
            buffer = operand1.value.ToString();
            history += buffer;
            his.Items.Add(history);
            op = null;
            history = "";
            behind_text.Content = "";
            Text.Content = buffer;
        }
    }
}
