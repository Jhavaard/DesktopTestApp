namespace DesktopTestApp.Lecturer_Components
{
    partial class LogoutTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoutTab));
            this.btnLogout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveBorderThickness = 1;
            this.btnLogout.ActiveCornerRadius = 20;
            this.btnLogout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(16)))), ((int)(((byte)(45)))));
            this.btnLogout.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogout.ActiveLineColor = System.Drawing.Color.Red;
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.ButtonText = "Yes, Log Me Out!";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.IdleBorderThickness = 2;
            this.btnLogout.IdleCornerRadius = 30;
            this.btnLogout.IdleFillColor = System.Drawing.Color.Crimson;
            this.btnLogout.IdleForecolor = System.Drawing.Color.White;
            this.btnLogout.IdleLineColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Location = new System.Drawing.Point(202, 100);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(183, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "                  Are You Sure You Want To Logout? \r\nMake Sure To Save All Your W" +
    "ork Before Logging Out!";
            // 
            // LogoutTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Name = "LogoutTab";
            this.Size = new System.Drawing.Size(574, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnLogout;
        private System.Windows.Forms.Label label1;
    }
}
