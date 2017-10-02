namespace CapaPresentacion
{
    partial class FrmConcepto
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConcepto));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new Telerik.WinControls.UI.RadTextBox();
            this.txtDescripcion = new Telerik.WinControls.UI.RadTextBoxControl();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new Telerik.WinControls.UI.RadButton();
            this.btnModificar = new Telerik.WinControls.UI.RadButton();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.grvConcepto = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvConcepto.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "GESTIONAR CONCEPTO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID |";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(117, 45);
            this.txtID.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtID.Name = "txtID";
            // 
            // 
            // 
            this.txtID.RootElement.MinSize = new System.Drawing.Size(0, 24);
            this.txtID.Size = new System.Drawing.Size(47, 24);
            this.txtID.TabIndex = 9;
            this.txtID.ThemeName = "VisualStudio2012Light";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(117, 71);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(318, 36);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.ThemeName = "VisualStudio2012Light";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripción |";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(460, 203);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 24);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.ThemeName = "VisualStudio2012Light";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(460, 143);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 24);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.ThemeName = "VisualStudio2012Light";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(460, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 24);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.ThemeName = "VisualStudio2012Light";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grvConcepto
            // 
            this.grvConcepto.Location = new System.Drawing.Point(39, 113);
            // 
            // 
            // 
            this.grvConcepto.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.FieldName = "Descripcion";
            gridViewTextBoxColumn2.HeaderText = "Descripción";
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.Width = 330;
            this.grvConcepto.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.grvConcepto.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grvConcepto.Name = "grvConcepto";
            this.grvConcepto.ReadOnly = true;
            this.grvConcepto.ShowGroupPanel = false;
            this.grvConcepto.Size = new System.Drawing.Size(415, 150);
            this.grvConcepto.TabIndex = 17;
            this.grvConcepto.ThemeName = "VisualStudio2012Light";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(460, 173);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(79, 24);
            this.radButton1.TabIndex = 15;
            this.radButton1.Text = "CANCELAR";
            this.radButton1.ThemeName = "VisualStudio2012Light";
            this.radButton1.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 289);
            this.Controls.Add(this.grvConcepto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConcepto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBCORP";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmConcepto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvConcepto.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadTextBox txtID;
        private Telerik.WinControls.UI.RadTextBoxControl txtDescripcion;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadButton btnEliminar;
        private Telerik.WinControls.UI.RadButton btnModificar;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadGridView grvConcepto;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
