using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2004";
            TextBox[] Grupotextbox = { pk_id_cliente, Codigo_nomina, Fecha_inicial, Fecha_final, Valor_nominal };
            TextBox[] Idtextbox = { pk_id_cliente, Codigo_nomina };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_clientes;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_clientes, Grupotextbox, "hoteleria");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Nomina_Load(object sender, EventArgs e)
        {

        }
    }
}
