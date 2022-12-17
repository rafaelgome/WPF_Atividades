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
        private Cliente y;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            y = new Cliente();
            y.SetNome(nome.Text);
            y.SetCpf(cpf.Text);
        }

        private void adicionar_Click(object sender, RoutedEventArgs e)
        {
            Conta x = new Conta();
            x.SetNumero(numero.Text);
            x.SetAgencia(agencia.Text);
            x.SetSaldo(double.Parse(saldo.Text)); 
            y.Inserir(x);
            y.SaldoTotal(x.GetSaldo());

        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            list.Text = null;
            foreach (Conta i in y.Listar())
                list.Text += $"{i.ToString()}\n";
        }

        private void saldo_total_Click(object sender, RoutedEventArgs e)
        {
            list_saldo.Text = y.ToString();
        }
    }
}
