
namespace Vista
{
    partial class Departamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pk_id_piso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoDepartamento = new System.Windows.Forms.TextBox();
            this.Nombre_departamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Estatus_departamento = new System.Windows.Forms.TextBox();
            this.tbl_piso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_piso)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 11);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CodigoDepartamento";
            // 
            // pk_id_piso
            // 
            this.pk_id_piso.Location = new System.Drawing.Point(167, 205);
            this.pk_id_piso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pk_id_piso.Name = "pk_id_piso";
            this.pk_id_piso.Size = new System.Drawing.Size(213, 22);
            this.pk_id_piso.TabIndex = 3;
            this.pk_id_piso.Tag = "pk_id_piso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre_departamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CodigoDepartamento
            // 
            this.CodigoDepartamento.Location = new System.Drawing.Point(167, 240);
            this.CodigoDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodigoDepartamento.Name = "CodigoDepartamento";
            this.CodigoDepartamento.Size = new System.Drawing.Size(213, 22);
            this.CodigoDepartamento.TabIndex = 5;
            this.CodigoDepartamento.Tag = "CodigoDepartamento";
            // 
            // Nombre_departamento
            // 
            this.Nombre_departamento.Location = new System.Drawing.Point(167, 278);
            this.Nombre_departamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nombre_departamento.Name = "Nombre_departamento";
            this.Nombre_departamento.Size = new System.Drawing.Size(213, 22);
            this.Nombre_departamento.TabIndex = 6;
            this.Nombre_departamento.Tag = "Nombre_departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estatus_departamento";
            // 
            // Estatus_departamento
            // 
            this.Estatus_departamento.Location = new System.Drawing.Point(167, 323);
            this.Estatus_departamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Estatus_departamento.Name = "Estatus_departamento";
            this.Estatus_departamento.Size = new System.Drawing.Size(213, 22);
            this.Estatus_departamento.TabIndex = 8;
            this.Estatus_departamento.Tag = "Estatus_departamento";
            // 
            // tbl_piso
            // 
            this.tbl_piso.AllowUserToAddRows = false;
            this.tbl_piso.AllowUserToDeleteRows = false;
            this.tbl_piso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_piso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_piso.Location = new System.Drawing.Point(406, 205);
            this.tbl_piso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_piso.Name = "tbl_piso";
            this.tbl_piso.ReadOnly = true;
            this.tbl_piso.RowHeadersWidth = 62;
            this.tbl_piso.RowTemplate.Height = 28;
            this.tbl_piso.Size = new System.Drawing.Size(358, 201);
            this.tbl_piso.TabIndex = 9;
            this.tbl_piso.Tag = "tbl_piso";
            // 
            // Pisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 415);
            this.Controls.Add(this.tbl_piso);
            this.Controls.Add(this.Estatus_departamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nombre_departamento);
            this.Controls.Add(this.CodigoDepartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pk_id_piso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pisos";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Pisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_piso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pk_id_piso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoDepartamento;
        private System.Windows.Forms.TextBox Nombre_departamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Estatus_departamento;
        private System.Windows.Forms.DataGridView tbl_piso;
    }
}