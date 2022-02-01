namespace DesktopTestApp.Lecturer_Components
{
    partial class SelectTestTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectTestTab));
            this.lbSelTest = new System.Windows.Forms.ListBox();
            this.btnSelect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lbSelTest
            // 
            this.lbSelTest.BackColor = System.Drawing.SystemColors.Window;
            this.lbSelTest.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelTest.ForeColor = System.Drawing.Color.Tomato;
            this.lbSelTest.FormattingEnabled = true;
            this.lbSelTest.ItemHeight = 23;
            this.lbSelTest.Location = new System.Drawing.Point(31, 34);
            this.lbSelTest.Name = "lbSelTest";
            this.lbSelTest.Size = new System.Drawing.Size(513, 257);
            this.lbSelTest.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.ActiveBorderThickness = 1;
            this.btnSelect.ActiveCornerRadius = 20;
            this.btnSelect.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSelect.ActiveForecolor = System.Drawing.Color.White;
            this.btnSelect.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSelect.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.ButtonText = "Select";
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSelect.IdleBorderThickness = 1;
            this.btnSelect.IdleCornerRadius = 20;
            this.btnSelect.IdleFillColor = System.Drawing.Color.White;
            this.btnSelect.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSelect.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSelect.Location = new System.Drawing.Point(236, 336);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 36);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SelectTestTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbSelTest);
            this.Name = "SelectTestTab";
            this.Size = new System.Drawing.Size(574, 394);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSelTest;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSelect;
    }
}
