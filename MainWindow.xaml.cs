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
        string buffer = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add_digit(object sender, RoutedEventArgs e)
        {
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
            Plus pluser = new Plus();
            sumarize(); 
    
            if (op != null)
            {
                operand1 = op.Calculate(operand2, operand1);
                buffer = operand1.value.ToString();
                Text.Content = buffer;
            }
            else
            {
                buffer = "";
                Text.Content = buffer;
            }
            op = pluser;
        }

        private void division_click(object sender, RoutedEventArgs e)
        {
            Division del = new Division();
            sumarize();

            if (op != null)
            {
                operand1 = op.Calculate(operand2, operand1);
                buffer = operand1.value.ToString();
                Text.Content = buffer;
            }
            else
            {
                buffer = "";
                Text.Content = buffer;
            }
            op = del;
        }
        private void result_click(object sender, RoutedEventArgs e)
        {

        }


    }
}
