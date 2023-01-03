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
    public partial class Puesto : Form
    {
        public Puesto()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2002";
            TextBox[] Grupotextbox = { pk_id_puesto, nombre, puesto1 };
            TextBox[] Idtextbox = { pk_id_puesto, nombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_puesto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_puesto, Grupotextbox, "hoteleria");
        }

        private void Servicios_Load(object sender, EventArgs e)
        {

        }

        private void tbl_servicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void estado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
