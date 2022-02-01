namespace DesktopTestApp.Student_Components
{
    partial class StudentPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPortal));
            this.LbTitle = new System.Windows.Forms.Label();
            this.lbDescrip = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.picBxStudPort = new System.Windows.Forms.PictureBox();
            this.picBxStu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxStudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxStu)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.White;
            this.LbTitle.Location = new System.Drawing.Point(56, 22);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(122, 21);
            this.LbTitle.TabIndex = 3;
            this.LbTitle.Text = "Student Portal";
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrip.ForeColor = System.Drawing.Color.White;
            this.lbDescrip.Location = new System.Drawing.Point(19, 152);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(192, 56);
            this.lbDescrip.TabIndex = 5;
            this.lbDescrip.Text = "Enter the student portal to sign in\r\n     into your student account,\r\n         wr" +
    "ite test, check scores\r\n                  view memo.\r\n";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 500;
            this.bunifuElipse1.TargetControl = this;
            // 
            // picBxStudPort
            // 
            this.picBxStudPort.Image = global::DesktopTestApp.Properties.Resources.StudentPtlDefault;
            this.picBxStudPort.Location = new System.Drawing.Point(0, 0);
            this.picBxStudPort.Name = "picBxStudPort";
            this.picBxStudPort.Size = new System.Drawing.Size(230, 230);
            this.picBxStudPort.TabIndex = 6;
            this.picBxStudPort.TabStop = false;
            this.picBxStudPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBxStudPort_MouseDown);
            this.picBxStudPort.MouseEnter += new System.EventHandler(this.picBxStudPort_MouseEnter);
            this.picBxStudPort.MouseLeave += new System.EventHandler(this.picBxStudPort_MouseLeave);
            // 
            // picBxStu
            // 
            this.picBxStu.Image = ((System.Drawing.Image)(resources.GetObject("picBxStu.Image")));
            this.picBxStu.Location = new System.Drawing.Point(71, 61);
            this.picBxStu.Name = "picBxStu";
            this.picBxStu.Size = new System.Drawing.Size(92, 83);
            this.picBxStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxStu.TabIndex = 4;
            this.picBxStu.TabStop = false;
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.picBxStudPort);
            this.Controls.Add(this.lbDescrip);
            this.Controls.Add(this.picBxStu);
            this.Controls.Add(this.LbTitle);
            this.Name = "StudentPortal";
            this.Size = new System.Drawing.Size(230, 230);
            ((System.ComponentModel.ISupportInitialize)(this.picBxStudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBxStu;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label lbDescrip;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.PictureBox picBxStudPort;
    }
}
