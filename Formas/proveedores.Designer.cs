
namespace Tecnoservice.Formas
{
    partial class proveedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.txtNomContac = new System.Windows.Forms.TextBox();
            this.txtRazo = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.Radbtn_Inactivo = new System.Windows.Forms.RadioButton();
            this.Radbtn_Activo = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteActive = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new Tecnoservice.DsClientesTableAdapters.ClientesTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new Tecnoservice.DsClientes();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpEstado.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del contacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Location = new System.Drawing.Point(130, 63);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(142, 20);
            this.txtIDProveedor.TabIndex = 0;
            // 
            // txtNomContac
            // 
            this.txtNomContac.Location = new System.Drawing.Point(129, 152);
            this.txtNomContac.Name = "txtNomContac";
            this.txtNomContac.Size = new System.Drawing.Size(142, 20);
            this.txtNomContac.TabIndex = 2;
            // 
            // txtRazo
            // 
            this.txtRazo.Location = new System.Drawing.Point(129, 105);
            this.txtRazo.Name = "txtRazo";
            this.txtRazo.Size = new System.Drawing.Size(142, 20);
            this.txtRazo.TabIndex = 1;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(129, 192);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(142, 20);
            this.txtTelef.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 224);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(142, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 307);
            this.dataGridView1.TabIndex = 5;
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.Radbtn_Inactivo);
            this.grpEstado.Controls.Add(this.Radbtn_Activo);
            this.grpEstado.Location = new System.Drawing.Point(20, 263);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(207, 55);
            this.grpEstado.TabIndex = 6;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado";
            // 
            // Radbtn_Inactivo
            // 
            this.Radbtn_Inactivo.AutoSize = true;
            this.Radbtn_Inactivo.Location = new System.Drawing.Point(97, 26);
            this.Radbtn_Inactivo.Name = "Radbtn_Inactivo";
            this.Radbtn_Inactivo.Size = new System.Drawing.Size(63, 17);
            this.Radbtn_Inactivo.TabIndex = 1;
            this.Radbtn_Inactivo.TabStop = true;
            this.Radbtn_Inactivo.Text = "Inactivo";
            this.Radbtn_Inactivo.UseVisualStyleBackColor = true;
            // 
            // Radbtn_Activo
            // 
            this.Radbtn_Activo.AutoSize = true;
            this.Radbtn_Activo.Location = new System.Drawing.Point(6, 26);
            this.Radbtn_Activo.Name = "Radbtn_Activo";
            this.Radbtn_Activo.Size = new System.Drawing.Size(55, 17);
            this.Radbtn_Activo.TabIndex = 0;
            this.Radbtn_Activo.TabStop = true;
            this.Radbtn_Activo.Text = "Activo";
            this.Radbtn_Activo.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnActualizar,
            this.btnDeleteActive});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(819, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::Tecnoservice.Properties.Resources.disquete;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnDeleteActive
            // 
            this.btnDeleteActive.Name = "btnDeleteActive";
            this.btnDeleteActive.Size = new System.Drawing.Size(50, 22);
            this.btnDeleteActive.Text = "Eliminar";
            this.btnDeleteActive.ToolTipText = "Eliminar";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(152, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "DsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 382);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.txtRazo);
            this.Controls.Add(this.txtNomContac);
            this.Controls.Add(this.txtIDProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.TextBox txtNomContac;
        private System.Windows.Forms.TextBox txtRazo;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.RadioButton Radbtn_Inactivo;
        private System.Windows.Forms.RadioButton Radbtn_Activo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripLabel btnDeleteActive;
        private System.Windows.Forms.Button btnDelete;
        private DsClientesTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DsClientes dsClientes;
    }
}