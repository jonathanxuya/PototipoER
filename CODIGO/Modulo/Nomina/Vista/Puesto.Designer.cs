
namespace Vista
{
    partial class Puesto
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
            this.puesto1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.pk_id_puesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_puesto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_puesto)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 11);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 1;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // puesto1
            // 
            this.puesto1.Location = new System.Drawing.Point(170, 298);
            this.puesto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.puesto1.Name = "puesto1";
            this.puesto1.Size = new System.Drawing.Size(213, 22);
            this.puesto1.TabIndex = 14;
            this.puesto1.Tag = "puesto1";
            this.puesto1.TextChanged += new System.EventHandler(this.estado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Puesto";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(170, 249);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(213, 22);
            this.nombre.TabIndex = 12;
            this.nombre.Tag = "nombre";
            // 
            // pk_id_puesto
            // 
            this.pk_id_puesto.Location = new System.Drawing.Point(170, 205);
            this.pk_id_puesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pk_id_puesto.Name = "pk_id_puesto";
            this.pk_id_puesto.Size = new System.Drawing.Size(213, 22);
            this.pk_id_puesto.TabIndex = 11;
            this.pk_id_puesto.Tag = "pk_id_puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // tbl_puesto
            // 
            this.tbl_puesto.AllowUserToAddRows = false;
            this.tbl_puesto.AllowUserToDeleteRows = false;
            this.tbl_puesto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_puesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_puesto.Location = new System.Drawing.Point(419, 202);
            this.tbl_puesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_puesto.Name = "tbl_puesto";
            this.tbl_puesto.ReadOnly = true;
            this.tbl_puesto.RowHeadersWidth = 62;
            this.tbl_puesto.RowTemplate.Height = 28;
            this.tbl_puesto.Size = new System.Drawing.Size(358, 219);
            this.tbl_puesto.TabIndex = 15;
            this.tbl_puesto.Tag = "tbl_puesto";
            this.tbl_puesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_servicios_CellContentClick);
            // 
            // Puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.tbl_puesto);
            this.Controls.Add(this.puesto1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pk_id_puesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Puesto";
            this.Text = "Puesto";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_puesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox puesto1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox pk_id_puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbl_puesto;
    }
}