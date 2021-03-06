using System;
using System.Collections.Generic;
using System.Data.OracleClient;
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
using System.Windows.Shapes;

namespace NoMasAccidentesv2
{
    /// <summary>
    /// Lógica de interacción para InicioCliente.xaml
    /// </summary>
    public partial class InicioCliente : Window
    {
        [Obsolete]
        OracleConnection conexion = new OracleConnection("DATA SOURCE=orcl; user id = ALONSO; password= alonso");

        [Obsolete]
        public InicioCliente()
        {
            InitializeComponent();
            OracleCommand comando = new OracleCommand("SELECT * FROM CLIENTE WHERE CORREO= :email", conexion);
            comando.Parameters.AddWithValue(":email", ((MainWindow)Application.Current.MainWindow).txtEmail.Text);
            conexion.Open();
            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                lblName.Content = lector["NOMBRE"].ToString();
                lblRut.Content = lector["RUT"].ToString() + "-" + lector["CV_RUT"].ToString();
                lblAddress.Content = lector["DIRECCION"].ToString();
                lblEmail.Content = lector["CORREO"].ToString();
            }
        }
    }
}
