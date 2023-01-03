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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2003";
            TextBox[] Grupotextbox = { pk_id_habitacion, nombre_empleado, codigo_puesto, sueldo_empleado, estatus_empleado };
            TextBox[] Idtextbox = { pk_id_habitacion, nombre_empleado };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_habitaciones;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_habitaciones, Grupotextbox, "hoteleria");
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
