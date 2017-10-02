namespace CapaPresentacion
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new Telerik.WinControls.UI.RadButton();
            this.cboEmpresa = new Telerik.WinControls.UI.RadDropDownList();
            this.btnNuevaEmpresa = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPRESA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar Empresa |";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(108, 103);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(180, 31);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.ThemeName = "VisualStudio2012Light";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.Location = new System.Drawing.Point(61, 68);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(287, 24);
            this.cboEmpresa.TabIndex = 6;
            this.cboEmpresa.ThemeName = "VisualStudio2012Light";
            // 
            // btnNuevaEmpresa
            // 
            this.btnNuevaEmpresa.Location = new System.Drawing.Point(270, 33);
            this.btnNuevaEmpresa.Name = "btnNuevaEmpresa";
            this.btnNuevaEmpresa.Size = new System.Drawing.Size(78, 24);
            this.btnNuevaEmpresa.TabIndex = 7;
            this.btnNuevaEmpresa.Text = "Nuevo";
            this.btnNuevaEmpresa.ThemeName = "VisualStudio2012Light";
            this.btnNuevaEmpresa.Click += new System.EventHandler(this.btnNuevaEmpresa_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 148);
            this.Controls.Add(this.btnNuevaEmpresa);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnIngresar;
        private Telerik.WinControls.UI.RadDropDownList cboEmpresa;
        private Telerik.WinControls.UI.RadButton btnNuevaEmpresa;
    }
}
