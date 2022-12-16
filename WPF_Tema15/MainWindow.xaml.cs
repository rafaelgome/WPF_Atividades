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

namespace WPF_Tema15
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conta x = new Conta();
            x.SetNumero(numero.Text);
            x.SetAgencia(agencia.Text);
            x.SetSaldo(double.Parse(saldo.Text));

            Cliente y = new Cliente();
            y.SetNome(nome.Text);
            y.SetCpf(cpf.Text);

        }
    }
}
