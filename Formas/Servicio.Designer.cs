
namespace Tecnoservice.Formas
{
    partial class Servicio
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
            this.Txbx_ID_Emp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmbx_Servicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LB_Dinero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Totalizar = new System.Windows.Forms.Button();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.DescServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txbx_ID_Emp
            // 
            this.Txbx_ID_Emp.Location = new System.Drawing.Point(27, 54);
            this.Txbx_ID_Emp.Name = "Txbx_ID_Emp";
            this.Txbx_ID_Emp.Size = new System.Drawing.Size(144, 20);
            this.Txbx_ID_Emp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Empleado";
            // 
            // Cmbx_Servicio
            // 
            this.Cmbx_Servicio.FormattingEnabled = true;
            this.Cmbx_Servicio.Items.AddRange(new object[] {
            "Limpieza de Dispositivo",
            "Reparación",
            "Cambio de piezas",
            "Liberación de dispositivo",
            "Formateo"});
            this.Cmbx_Servicio.Location = new System.Drawing.Point(27, 117);
            this.Cmbx_Servicio.Name = "Cmbx_Servicio";
            this.Cmbx_Servicio.Size = new System.Drawing.Size(163, 21);
            this.Cmbx_Servicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescServicio,
            this.PrecioServicio});
            this.dataGridView1.Location = new System.Drawing.Point(329, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(388, 295);
            this.dataGridView1.TabIndex = 4;
            // 
            // LB_Dinero
            // 
            this.LB_Dinero.AutoSize = true;
            this.LB_Dinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Dinero.Location = new System.Drawing.Point(58, 266);
            this.LB_Dinero.Name = "LB_Dinero";
            this.LB_Dinero.Size = new System.Drawing.Size(249, 58);
            this.LB_Dinero.TabIndex = 18;
            this.LB_Dinero.Text = "00,000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 58);
            this.label4.TabIndex = 17;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total deArticulos:";
            // 
            // Bt_Totalizar
            // 
            this.Bt_Totalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Totalizar.Location = new System.Drawing.Point(177, 210);
            this.Bt_Totalizar.Name = "Bt_Totalizar";
            this.Bt_Totalizar.Size = new System.Drawing.Size(118, 42);
            this.Bt_Totalizar.TabIndex = 15;
            this.Bt_Totalizar.Text = "Totalizar";
            this.Bt_Totalizar.UseVisualStyleBackColor = true;
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Agregar.Location = new System.Drawing.Point(26, 156);
            this.Bt_Agregar.Name = "Bt_Agregar";
            this.Bt_Agregar.Size = new System.Drawing.Size(118, 42);
            this.Bt_Agregar.TabIndex = 19;
            this.Bt_Agregar.Text = "Agregar";
            this.Bt_Agregar.UseVisualStyleBackColor = true;
            // 
            // DescServicio
            // 
            this.DescServicio.HeaderText = "Descripción del Servicio";
            this.DescServicio.Name = "DescServicio";
            this.DescServicio.ReadOnly = true;
            this.DescServicio.Width = 200;
            // 
            // PrecioServicio
            // 
            this.PrecioServicio.HeaderText = "Precio del Servicio";
            this.PrecioServicio.Name = "PrecioServicio";
            this.PrecioServicio.ReadOnly = true;
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 352);
            this.Controls.Add(this.Bt_Agregar);
            this.Controls.Add(this.LB_Dinero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bt_Totalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmbx_Servicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txbx_ID_Emp);
            this.Name = "Servicio";
            this.Text = "Servicio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txbx_ID_Emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmbx_Servicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LB_Dinero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_Totalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioServicio;
        private System.Windows.Forms.Button Bt_Agregar;
    }
}