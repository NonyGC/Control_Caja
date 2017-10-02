namespace CapaPresentacion
{
    partial class FrmEmpresa
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRuc = new Telerik.WinControls.UI.RadTextBox();
            this.TxtRazonSocial = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccion = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrvEmpresa = new Telerik.WinControls.UI.RadGridView();
            this.BtnModificar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnEliminar = new Telerik.WinControls.UI.RadButton();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.grpEmpresa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvEmpresa.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            this.grpEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "RUC |";
            // 
            // TxtRuc
            // 
            this.TxtRuc.Location = new System.Drawing.Point(102, 15);
            this.TxtRuc.MaxLength = 11;
            this.TxtRuc.MinimumSize = new System.Drawing.Size(0, 24);
            this.TxtRuc.Name = "TxtRuc";
            // 
            // 
            // 
            this.TxtRuc.RootElement.MinSize = new System.Drawing.Size(0, 24);
            this.TxtRuc.Size = new System.Drawing.Size(119, 24);
            this.TxtRuc.TabIndex = 6;
            this.TxtRuc.ThemeName = "VisualStudio2012Light";
            this.TxtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRuc_KeyPress);
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(102, 42);
            this.TxtRazonSocial.MinimumSize = new System.Drawing.Size(0, 24);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            // 
            // 
            // 
            this.TxtRazonSocial.RootElement.MinSize = new System.Drawing.Size(0, 24);
            this.TxtRazonSocial.Size = new System.Drawing.Size(439, 24);
            this.TxtRazonSocial.TabIndex = 7;
            this.TxtRazonSocial.ThemeName = "VisualStudio2012Light";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razón Social |";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(102, 69);
            this.TxtDireccion.MinimumSize = new System.Drawing.Size(0, 24);
            this.TxtDireccion.Name = "TxtDireccion";
            // 
            // 
            // 
            this.TxtDireccion.RootElement.MinSize = new System.Drawing.Size(0, 24);
            this.TxtDireccion.Size = new System.Drawing.Size(439, 24);
            this.TxtDireccion.TabIndex = 8;
            this.TxtDireccion.ThemeName = "VisualStudio2012Light";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección |";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(105, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "GESTIONAR EMPRESA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrvEmpresa
            // 
            this.GrvEmpresa.Location = new System.Drawing.Point(24, 186);
            // 
            // 
            // 
            this.GrvEmpresa.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "CÓDIGO";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.FieldName = "Ruc";
            gridViewTextBoxColumn2.HeaderText = "RUC";
            gridViewTextBoxColumn2.Name = "Ruc";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "RazonSocial";
            gridViewTextBoxColumn3.HeaderText = "RAZÓN SOCIAL";
            gridViewTextBoxColumn3.Name = "RazonSocial";
            gridViewTextBoxColumn3.Width = 180;
            gridViewTextBoxColumn4.FieldName = "Direccion";
            gridViewTextBoxColumn4.HeaderText = "DIRECCIÓN";
            gridViewTextBoxColumn4.Name = "Direccion";
            gridViewTextBoxColumn4.Width = 200;
            this.GrvEmpresa.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.GrvEmpresa.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GrvEmpresa.Name = "GrvEmpresa";
            this.GrvEmpresa.ReadOnly = true;
            this.GrvEmpresa.ShowGroupPanel = false;
            this.GrvEmpresa.Size = new System.Drawing.Size(563, 144);
            this.GrvEmpresa.TabIndex = 8;
            this.GrvEmpresa.Text = "radGridView1";
            this.GrvEmpresa.ThemeName = "VisualStudio2012Light";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(359, 152);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(100, 24);
            this.BtnModificar.TabIndex = 38;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.ThemeName = "VisualStudio2012Light";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(232, 152);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 24);
            this.BtnCancelar.TabIndex = 36;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.ThemeName = "VisualStudio2012Light";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(465, 152);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 24);
            this.BtnEliminar.TabIndex = 37;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.ThemeName = "VisualStudio2012Light";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(126, 152);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 24);
            this.BtnGuardar.TabIndex = 35;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.ThemeName = "VisualStudio2012Light";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // grpEmpresa
            // 
            this.grpEmpresa.Controls.Add(this.label1);
            this.grpEmpresa.Controls.Add(this.TxtRuc);
            this.grpEmpresa.Controls.Add(this.TxtRazonSocial);
            this.grpEmpresa.Controls.Add(this.label2);
            this.grpEmpresa.Controls.Add(this.TxtDireccion);
            this.grpEmpresa.Controls.Add(this.label3);
            this.grpEmpresa.Location = new System.Drawing.Point(24, 37);
            this.grpEmpresa.Name = "grpEmpresa";
            this.grpEmpresa.Size = new System.Drawing.Size(563, 101);
            this.grpEmpresa.TabIndex = 39;
            this.grpEmpresa.TabStop = false;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 355);
            this.Controls.Add(this.grpEmpresa);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GrvEmpresa);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpresa";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtRuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvEmpresa.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            this.grpEmpresa.ResumeLayout(false);
            this.grpEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox TxtRuc;
        private Telerik.WinControls.UI.RadTextBox TxtRazonSocial;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox TxtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadGridView GrvEmpresa;
        private Telerik.WinControls.UI.RadButton BtnModificar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadButton BtnEliminar;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private System.Windows.Forms.GroupBox grpEmpresa;
    }
}
