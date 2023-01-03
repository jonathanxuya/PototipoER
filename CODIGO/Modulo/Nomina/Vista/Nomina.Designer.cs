
namespace Vista
{
    partial class Nomina
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
            this.Fecha_final = new System.Windows.Forms.TextBox();
            this.Fecha_inicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Valor_nominal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Codigo_nomina = new System.Windows.Forms.TextBox();
            this.pk_id_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(50, 11);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Fecha_final
            // 
            this.Fecha_final.Location = new System.Drawing.Point(187, 346);
            this.Fecha_final.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha_final.Name = "Fecha_final";
            this.Fecha_final.Size = new System.Drawing.Size(213, 22);
            this.Fecha_final.TabIndex = 34;
            this.Fecha_final.Tag = "Fecha_final";
            // 
            // Fecha_inicial
            // 
            this.Fecha_inicial.Location = new System.Drawing.Point(187, 301);
            this.Fecha_inicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha_inicial.Name = "Fecha_inicial";
            this.Fecha_inicial.Size = new System.Drawing.Size(213, 22);
            this.Fecha_inicial.TabIndex = 33;
            this.Fecha_inicial.Tag = "Fecha_inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha_final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha_inicial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Valor_nominal
            // 
            this.Valor_nominal.Location = new System.Drawing.Point(187, 396);
            this.Valor_nominal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Valor_nominal.Name = "Valor_nominal";
            this.Valor_nominal.Size = new System.Drawing.Size(213, 22);
            this.Valor_nominal.TabIndex = 30;
            this.Valor_nominal.Tag = "Valor_nominal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Valor_nominal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Codigo_nomina
            // 
            this.Codigo_nomina.Location = new System.Drawing.Point(187, 256);
            this.Codigo_nomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Codigo_nomina.Name = "Codigo_nomina";
            this.Codigo_nomina.Size = new System.Drawing.Size(213, 22);
            this.Codigo_nomina.TabIndex = 28;
            this.Codigo_nomina.Tag = "Codigo_nomina";
            // 
            // pk_id_cliente
            // 
            this.pk_id_cliente.Location = new System.Drawing.Point(187, 212);
            this.pk_id_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pk_id_cliente.Name = "pk_id_cliente";
            this.pk_id_cliente.Size = new System.Drawing.Size(213, 22);
            this.pk_id_cliente.TabIndex = 27;
            this.pk_id_cliente.Tag = "pk_id_cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Codigo_nomina";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID";
            // 
            // tbl_clientes
            // 
            this.tbl_clientes.AllowUserToAddRows = false;
            this.tbl_clientes.AllowUserToDeleteRows = false;
            this.tbl_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_clientes.Location = new System.Drawing.Point(415, 210);
            this.tbl_clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_clientes.Name = "tbl_clientes";
            this.tbl_clientes.ReadOnly = true;
            this.tbl_clientes.RowHeadersWidth = 62;
            this.tbl_clientes.RowTemplate.Height = 28;
            this.tbl_clientes.Size = new System.Drawing.Size(434, 263);
            this.tbl_clientes.TabIndex = 35;
            this.tbl_clientes.Tag = "tbl_clientes";
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 482);
            this.Controls.Add(this.tbl_clientes);
            this.Controls.Add(this.Fecha_final);
            this.Controls.Add(this.Fecha_inicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Valor_nominal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Codigo_nomina);
            this.Controls.Add(this.pk_id_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox Fecha_final;
        private System.Windows.Forms.TextBox Fecha_inicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Valor_nominal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Codigo_nomina;
        private System.Windows.Forms.TextBox pk_id_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbl_clientes;
    }
}