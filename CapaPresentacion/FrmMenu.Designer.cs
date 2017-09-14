namespace CapaPresentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(50, 141);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(268, 29);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "INGRESAR SALDO INICIAL";
            this.radButton1.ThemeName = "VisualStudio2012Light";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(50, 176);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(268, 29);
            this.radButton2.TabIndex = 0;
            this.radButton2.Text = "INGRESAR MOVIMIENTO DE CAJA";
            this.radButton2.ThemeName = "VisualStudio2012Light";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(150, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "EMPRESA :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Location = new System.Drawing.Point(47, 84);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(271, 37);
            this.lblEmpresa.TabIndex = 3;
            this.lblEmpresa.Text = "EMPRESA";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU PRINCIPAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
