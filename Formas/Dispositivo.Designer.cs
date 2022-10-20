
namespace Tecnoservice.Formas
{
    partial class Dispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispositivo));
            this.txtIMEIDispo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModeloDispo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarcaDispo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetDispositivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDispositivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteActive = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIMEIDispo
            // 
            this.txtIMEIDispo.Location = new System.Drawing.Point(45, 270);
            this.txtIMEIDispo.Name = "txtIMEIDispo";
            this.txtIMEIDispo.Size = new System.Drawing.Size(207, 20);
            this.txtIMEIDispo.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "IMEI del Dispositivo:";
            // 
            // txtModeloDispo
            // 
            this.txtModeloDispo.Location = new System.Drawing.Point(45, 209);
            this.txtModeloDispo.Name = "txtModeloDispo";
            this.txtModeloDispo.Size = new System.Drawing.Size(207, 20);
            this.txtModeloDispo.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Modelo del Dispositivo:";
            // 
            // txtMarcaDispo
            // 
            this.txtMarcaDispo.Location = new System.Drawing.Point(45, 151);
            this.txtMarcaDispo.Name = "txtMarcaDispo";
            this.txtMarcaDispo.Size = new System.Drawing.Size(207, 20);
            this.txtMarcaDispo.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Marca del Dispositivo:";
            // 
            // txtDetDispositivo
            // 
            this.txtDetDispositivo.Location = new System.Drawing.Point(45, 337);
            this.txtDetDispositivo.Multiline = true;
            this.txtDetDispositivo.Name = "txtDetDispositivo";
            this.txtDetDispositivo.Size = new System.Drawing.Size(207, 88);
            this.txtDetDispositivo.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Detalles del Dispositivo:";
            // 
            // txtDispositivo
            // 
            this.txtDispositivo.Location = new System.Drawing.Point(45, 78);
            this.txtDispositivo.Name = "txtDispositivo";
            this.txtDispositivo.Size = new System.Drawing.Size(207, 20);
            this.txtDispositivo.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dispositivo:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(273, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(532, 306);
            this.dataGridView2.TabIndex = 35;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnDeleteActive});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 25);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDeleteActive
            // 
            this.btnDeleteActive.Name = "btnDeleteActive";
            this.btnDeleteActive.Size = new System.Drawing.Size(50, 22);
            this.btnDeleteActive.Text = "Eliminar";
            // 
            // Dispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtIMEIDispo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtModeloDispo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMarcaDispo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDetDispositivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDispositivo);
            this.Controls.Add(this.label5);
            this.Name = "Dispositivo";
            this.Text = "Dispositivo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIMEIDispo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModeloDispo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarcaDispo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetDispositivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDispositivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripLabel btnDeleteActive;
    }
}