
namespace Vista
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new NavegadorVista.Navegador();
            this.estatus_empleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_empleado = new System.Windows.Forms.TextBox();
            this.pk_id_habitacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codigo_puesto = new System.Windows.Forms.TextBox();
            this.sueldo_empleado = new System.Windows.Forms.TextBox();
            this.tbl_habitaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_habitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 4);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // estatus_empleado
            // 
            this.estatus_empleado.Location = new System.Drawing.Point(166, 415);
            this.estatus_empleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatus_empleado.Name = "estatus_empleado";
            this.estatus_empleado.Size = new System.Drawing.Size(213, 22);
            this.estatus_empleado.TabIndex = 20;
            this.estatus_empleado.Tag = "estatus_empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "estatus_empleado";
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.Location = new System.Drawing.Point(166, 242);
            this.nombre_empleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre_empleado.Name = "nombre_empleado";
            this.nombre_empleado.Size = new System.Drawing.Size(213, 22);
            this.nombre_empleado.TabIndex = 18;
            this.nombre_empleado.Tag = "nombre_empleado";
            // 
            // pk_id_habitacion
            // 
            this.pk_id_habitacion.Location = new System.Drawing.Point(166, 198);
            this.pk_id_habitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pk_id_habitacion.Name = "pk_id_habitacion";
            this.pk_id_habitacion.Size = new System.Drawing.Size(213, 22);
            this.pk_id_habitacion.TabIndex = 17;
            this.pk_id_habitacion.Tag = "pk_id_habitacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "nombre_empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "codigo_puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "sueldo_empleado";
            // 
            // codigo_puesto
            // 
            this.codigo_puesto.Location = new System.Drawing.Point(166, 298);
            this.codigo_puesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo_puesto.Name = "codigo_puesto";
            this.codigo_puesto.Size = new System.Drawing.Size(213, 22);
            this.codigo_puesto.TabIndex = 23;
            this.codigo_puesto.Tag = "codigo_puesto";
            // 
            // sueldo_empleado
            // 
            this.sueldo_empleado.Location = new System.Drawing.Point(166, 353);
            this.sueldo_empleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sueldo_empleado.Name = "sueldo_empleado";
            this.sueldo_empleado.Size = new System.Drawing.Size(213, 22);
            this.sueldo_empleado.TabIndex = 24;
            this.sueldo_empleado.Tag = "sueldo_empleado";
            // 
            // tbl_habitaciones
            // 
            this.tbl_habitaciones.AllowUserToAddRows = false;
            this.tbl_habitaciones.AllowUserToDeleteRows = false;
            this.tbl_habitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_habitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_habitaciones.Location = new System.Drawing.Point(395, 195);
            this.tbl_habitaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_habitaciones.Name = "tbl_habitaciones";
            this.tbl_habitaciones.ReadOnly = true;
            this.tbl_habitaciones.RowHeadersWidth = 62;
            this.tbl_habitaciones.RowTemplate.Height = 28;
            this.tbl_habitaciones.Size = new System.Drawing.Size(382, 323);
            this.tbl_habitaciones.TabIndex = 25;
            this.tbl_habitaciones.Tag = "tbl_habitaciones";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 528);
            this.Controls.Add(this.tbl_habitaciones);
            this.Controls.Add(this.sueldo_empleado);
            this.Controls.Add(this.codigo_puesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estatus_empleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre_empleado);
            this.Controls.Add(this.pk_id_habitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_habitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox estatus_empleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_empleado;
        private System.Windows.Forms.TextBox pk_id_habitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codigo_puesto;
        private System.Windows.Forms.TextBox sueldo_empleado;
        private System.Windows.Forms.DataGridView tbl_habitaciones;
    }
}