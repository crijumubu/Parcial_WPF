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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Administrador.xaml
    /// </summary>
    public partial class Administrador : Page
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            string year = clnConsultar.DisplayDate.Year.ToString();
            string month = clnConsultar.DisplayDate.Month.ToString();
            string day = clnConsultar.DisplayDate.Day.ToString();
            string time = DateTime.Now.ToLongTimeString();
            txtResultado.Text += "Ingresos" + txtIngresos.Text + "\n" + "Egresos" + txtEgresos.Text + "\n" + "Fecha de consulta: " + year + "/" + month + "/" + day + " " + time;

        }

        private void btnAvanzado_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no se encuentra disponible, estamos trabajando en ello, gracias");
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }
    }
}
