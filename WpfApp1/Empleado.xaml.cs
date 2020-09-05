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
    /// Lógica de interacción para Empleado.xaml
    /// </summary>
    public partial class Empleado : Page
    {
        public string[] Panes { get; set; }
        public Empleado()
        {
            InitializeComponent();
            Panes = new string[] { "Especial", "Alineado", "No alineado"};
            DataContext = this;
        }

        int precioEspeciales = 2000;
        int precioAlineado = 1000;
        int precioNoAlineado = 500;
        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            string TipoPan = cmbPan.Text.ToString();
            int cantidadPanes = Int32.Parse(txtCantidadPanes.Text);
            txtVentas.Text += "Nombre: " + txtNombre.Text + "\n" + "Cédula: " + txtCedula.Text + "\n" + "Tipo de pan: " + TipoPan + "\n" + "Cantidad de panes: " + txtCantidadPanes.Text + "\n" + "Total: ";
            switch (TipoPan)
            {
                case "Especial":
                    int total_es = precioEspeciales*cantidadPanes;
                    txtVentas.Text += total_es + "\n";
                    break;

                case "Alineado":
                    int total_ali = precioAlineado * cantidadPanes;
                    txtVentas.Text += total_ali + "\n";
                    break;

                case "No alineado":
                    int total_no = precioNoAlineado * cantidadPanes;
                    txtVentas.Text += total_no + "\n";
                    break;
            }
            string year = clnConsultar.DisplayDate.Year.ToString();
            string month = clnConsultar.DisplayDate.Month.ToString();
            string day = clnConsultar.DisplayDate.Day.ToString();
            string time = DateTime.Now.ToLongTimeString();
            txtVentas.Text += "Fecha de la orden: " + year + "/" + month + "/" + day + " " + time + "\n" + "\n";
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtVentas.Text = "";
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }
    }
}
