namespace CapaPresentacion
{
    partial class FrmSaldosFinales
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaldosFinales));
            this.GrvSaldosFinales = new Telerik.WinControls.UI.RadGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSaldosFinales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSaldosFinales.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GrvSaldosFinales
            // 
            this.GrvSaldosFinales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrvSaldosFinales.Location = new System.Drawing.Point(25, 100);
            // 
            // 
            // 
            this.GrvSaldosFinales.MasterTemplate.AllowAddNewRow = false;
            this.GrvSaldosFinales.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "Fecha";
            gridViewTextBoxColumn1.HeaderText = "FECHA";
            gridViewTextBoxColumn1.Name = "Fecha";
            gridViewTextBoxColumn1.Width = 80;
            gridViewTextBoxColumn2.FieldName = "IDC";
            gridViewTextBoxColumn2.HeaderText = "CAJA INICIO";
            gridViewTextBoxColumn2.Name = "IDC";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "SaldoInicial";
            gridViewTextBoxColumn3.HeaderText = "SALDO INICIAL";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "SaldoInicial";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "TotalIngreso";
            gridViewTextBoxColumn4.HeaderText = "TOTAL INGRESO";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "TotalIngreso";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "TotalEgreso";
            gridViewTextBoxColumn5.HeaderText = "TOTAL EGRESO";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "TotalEgreso";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.FieldName = "SaldoFinal";
            gridViewTextBoxColumn6.FormatString = "{0:C}";
            gridViewTextBoxColumn6.HeaderText = "SALDO FINAL";
            gridViewTextBoxColumn6.Name = "SaldoFinal";
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.FieldName = "Observacion";
            gridViewTextBoxColumn7.HeaderText = "OBSERVACIÓN";
            gridViewTextBoxColumn7.Name = "Observacion";
            gridViewTextBoxColumn7.Width = 300;
            this.GrvSaldosFinales.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.GrvSaldosFinales.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.GrvSaldosFinales.Name = "GrvSaldosFinales";
            this.GrvSaldosFinales.ReadOnly = true;
            this.GrvSaldosFinales.ShowGroupPanel = false;
            this.GrvSaldosFinales.Size = new System.Drawing.Size(615, 289);
            this.GrvSaldosFinales.TabIndex = 0;
            this.GrvSaldosFinales.ThemeName = "VisualStudio2012Light";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(546, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 15);
            this.lblFecha.TabIndex = 25;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Black;
            this.lblEmpresa.Location = new System.Drawing.Point(113, 61);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(72, 15);
            this.lblEmpresa.TabIndex = 26;
            this.lblEmpresa.Text = "Empresa |";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Empresa |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fecha |";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(70, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "SALDOS FINALES DE CAJAS CERRADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSaldosFinales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrvSaldosFinales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSaldosFinales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmSaldosFinales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrvSaldosFinales.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSaldosFinales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrvSaldosFinales;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
