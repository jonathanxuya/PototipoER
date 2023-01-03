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
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2001";
            TextBox[] Grupotextbox = { pk_id_piso, CodigoDepartamento, Nombre_departamento, Estatus_departamento };
            TextBox[] Idtextbox = { pk_id_piso, CodigoDepartamento };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_piso;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_piso, Grupotextbox, "hoteleria");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pisos_Load(object sender, EventArgs e)
        {

        }
    }
}
