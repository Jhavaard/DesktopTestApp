namespace DesktopTestApp.Lecturer_Components
{
    partial class LecturerPortal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerPortal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbDescrip = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picBxLecPort = new System.Windows.Forms.PictureBox();
            this.picBxLec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLecPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLec)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 500;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.BackColor = System.Drawing.Color.Transparent;
            this.lbDescrip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrip.ForeColor = System.Drawing.Color.White;
            this.lbDescrip.Location = new System.Drawing.Point(24, 151);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(183, 56);
            this.lbDescrip.TabIndex = 27;
            this.lbDescrip.Text = "Enter the lecturer portal to login\r\n    into your lecturer account,\r\n     create " +
    "test, create memo\r\n        view student results.";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(55, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(123, 21);
            this.lbTitle.TabIndex = 25;
            this.lbTitle.Text = "Lecturer Portal";
            // 
            // picBxLecPort
            // 
            this.picBxLecPort.Image = ((System.Drawing.Image)(resources.GetObject("picBxLecPort.Image")));
            this.picBxLecPort.Location = new System.Drawing.Point(-1, 0);
            this.picBxLecPort.Name = "picBxLecPort";
            this.picBxLecPort.Size = new System.Drawing.Size(230, 230);
            this.picBxLecPort.TabIndex = 28;
            this.picBxLecPort.TabStop = false;
            this.picBxLecPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBxLecPort_MouseDown);
            this.picBxLecPort.MouseEnter += new System.EventHandler(this.picBxLecPort_MouseEnter);
            this.picBxLecPort.MouseLeave += new System.EventHandler(this.picBxLecPort_MouseLeave);
            // 
            // picBxLec
            // 
            this.picBxLec.Image = ((System.Drawing.Image)(resources.GetObject("picBxLec.Image")));
            this.picBxLec.Location = new System.Drawing.Point(69, 63);
            this.picBxLec.Name = "picBxLec";
            this.picBxLec.Size = new System.Drawing.Size(92, 83);
            this.picBxLec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxLec.TabIndex = 26;
            this.picBxLec.TabStop = false;
            // 
            // LecturerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.picBxLecPort);
            this.Controls.Add(this.lbDescrip);
            this.Controls.Add(this.picBxLec);
            this.Controls.Add(this.lbTitle);
            this.Name = "LecturerPortal";
            this.Size = new System.Drawing.Size(230, 230);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLecPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lbDescrip;
        private System.Windows.Forms.PictureBox picBxLec;
        private System.Windows.Forms.Label lbTitle;
        public System.Windows.Forms.PictureBox picBxLecPort;
    }
}
