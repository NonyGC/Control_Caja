namespace CapaPresentacion
{
    partial class FrmDocumento
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumento));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.grvListadaComprobante = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionComprobante = new Telerik.WinControls.UI.RadTextBoxControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroComprobante = new Telerik.WinControls.UI.RadTextBox();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.grpBxGestionarCompr = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.btnNuevo = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvListadaComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListadaComprobante.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.grpBxGestionarCompr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grvListadaComprobante
            // 
            this.grvListadaComprobante.Location = new System.Drawing.Point(26, 154);
            // 
            // 
            // 
            this.grvListadaComprobante.MasterTemplate.AllowAddNewRow = false;
            this.grvListadaComprobante.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.FieldName = "Descripcion";
            gridViewTextBoxColumn2.HeaderText = "DESCRIPCIÓN";
            gridViewTextBoxColumn2.Name = "DESCRIPCION";
            gridViewTextBoxColumn2.Width = 401;
            gridViewTextBoxColumn3.FieldName = "Numero";
            gridViewTextBoxColumn3.HeaderText = "N° DOC";
            gridViewTextBoxColumn3.Name = "NDOC";
            this.grvListadaComprobante.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.grvListadaComprobante.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grvListadaComprobante.Name = "grvListadaComprobante";
            this.grvListadaComprobante.ReadOnly = true;
            this.grvListadaComprobante.ShowGroupPanel = false;
            this.grvListadaComprobante.Size = new System.Drawing.Size(529, 188);
            this.grvListadaComprobante.TabIndex = 0;
            this.grvListadaComprobante.ThemeName = "VisualStudio2012Light";
            this.grvListadaComprobante.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grvListadaComprobante_CellClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(90, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "GESTIONAR COMPROBANTE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcionComprobante
            // 
            this.txtDescripcionComprobante.Location = new System.Drawing.Point(99, 41);
            this.txtDescripcionComprobante.Multiline = true;
            this.txtDescripcionComprobante.Name = "txtDescripcionComprobante";
            this.txtDescripcionComprobante.Size = new System.Drawing.Size(383, 33);
            this.txtDescripcionComprobante.TabIndex = 2;
            this.txtDescripcionComprobante.ThemeName = "VisualStudio2012Light";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descripción |";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "N° Comprobante |";
            // 
            // txtNumeroComprobante
            // 
            this.txtNumeroComprobante.Location = new System.Drawing.Point(296, 11);
            this.txtNumeroComprobante.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtNumeroComprobante.Name = "txtNumeroComprobante";
            // 
            // 
            // 
            this.txtNumeroComprobante.RootElement.MinSize = new System.Drawing.Size(0, 24);
            this.txtNumeroComprobante.Size = new System.Drawing.Size(100, 24);
            this.txtNumeroComprobante.TabIndex = 4;
            this.txtNumeroComprobante.ThemeName = "VisualStudio2012Light";
            this.txtNumeroComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroComprobante_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(337, 124);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 24);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.ThemeName = "VisualStudio2012Light";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarActualizar_Click);
            // 
            // grpBxGestionarCompr
            // 
            this.grpBxGestionarCompr.Controls.Add(this.label3);
            this.grpBxGestionarCompr.Controls.Add(this.label1);
            this.grpBxGestionarCompr.Controls.Add(this.txtDescripcionComprobante);
            this.grpBxGestionarCompr.Controls.Add(this.txtID);
            this.grpBxGestionarCompr.Controls.Add(this.txtNumeroComprobante);
            this.grpBxGestionarCompr.Controls.Add(this.label5);
            this.grpBxGestionarCompr.Enabled = false;
            this.grpBxGestionarCompr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBxGestionarCompr.Location = new System.Drawing.Point(25, 36);
            this.grpBxGestionarCompr.Name = "grpBxGestionarCompr";
            this.grpBxGestionarCompr.Size = new System.Drawing.Size(529, 82);
            this.grpBxGestionarCompr.TabIndex = 6;
            this.grpBxGestionarCompr.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID |";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(99, 11);
            this.txtID.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtID.Name = "txtID";
            // 
            // 
            // 
            this.txtID.RootElement.MinSize = new System.Drawing.Size(0, 24);
            this.txtID.Size = new System.Drawing.Size(47, 24);
            this.txtID.TabIndex = 4;
            this.txtID.ThemeName = "VisualStudio2012Light";
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroComprobante_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(445, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 24);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.ThemeName = "VisualStudio2012Light";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(232, 124);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 24);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.ThemeName = "VisualStudio2012Light";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBxGestionarCompr);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grvListadaComprobante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDocumento";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvListadaComprobante.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListadaComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.grpBxGestionarCompr.ResumeLayout(false);
            this.grpBxGestionarCompr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGridView grvListadaComprobante;
        private Telerik.WinControls.UI.RadTextBoxControl txtDescripcionComprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtNumeroComprobante;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBxGestionarCompr;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnNuevo;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox txtID;
    }
}
