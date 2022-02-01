namespace DesktopTestApp.Student_Components
{
    partial class TestContentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestContentMenu));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblNumQues = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblLectName = new System.Windows.Forms.Label();
            this.picMenuIcon = new System.Windows.Forms.PictureBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenu.Controls.Add(this.lblDateCreated);
            this.pnMenu.Controls.Add(this.lblMarks);
            this.pnMenu.Controls.Add(this.lblNumQues);
            this.pnMenu.Controls.Add(this.lblTestName);
            this.pnMenu.Controls.Add(this.lblLectName);
            this.pnMenu.Controls.Add(this.picMenuIcon);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(340, 160);
            this.pnMenu.TabIndex = 9;
            this.pnMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseClick);
            this.pnMenu.MouseEnter += new System.EventHandler(this.pnMenu_MouseEnter);
            this.pnMenu.MouseLeave += new System.EventHandler(this.pnMenu_MouseLeave);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.ForeColor = System.Drawing.Color.White;
            this.lblDateCreated.Location = new System.Drawing.Point(128, 119);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(155, 21);
            this.lblDateCreated.TabIndex = 1;
            this.lblDateCreated.Text = "Created: 30/04/2018";
            this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateCreated.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseClick);
            this.lblDateCreated.MouseEnter += new System.EventHandler(this.pnMenu_MouseEnter);
            this.lblDateCreated.MouseLeave += new System.EventHandler(this.pnMenu_MouseLeave);
            // 
            // lblNumQues
            // 
            this.lblNumQues.AutoSize = true;
            this.lblNumQues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumQues.ForeColor = System.Drawing.Color.White;
            this.lblNumQues.Location = new System.Drawing.Point(128, 69);
            this.lblNumQues.Name = "lblNumQues";
            this.lblNumQues.Size = new System.Drawing.Size(124, 21);
            this.lblNumQues.TabIndex = 1;
            this.lblNumQues.Text = "No. Questions: 5";
            this.lblNumQues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumQues.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseClick);
            this.lblNumQues.MouseEnter += new System.EventHandler(this.pnMenu_MouseEnter);
            this.lblNumQues.MouseLeave += new System.EventHandler(this.pnMenu_MouseLeave);
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.ForeColor = System.Drawing.Color.White;
            this.lblTestName.Location = new System.Drawing.Point(128, 44);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(132, 21);
            this.lblTestName.TabIndex = 1;
            this.lblTestName.Text = "Test Name: Maths";
            this.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTestName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseClick);
            this.lblTestName.MouseEnter += new System.EventHandler(this.pnMenu_MouseEnter);
            this.lblTestName.MouseLeave += new System.EventHandler(this.pnMenu_MouseLeave);
            // 
            // lblLectName
            // 
            this.lblLectName.AutoSize = true;
            this.lblLectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectName.ForeColor = System.Drawing.Color.White;
            this.lblLectName.Location = new System.Drawing.Point(128, 19);
            this.lblLectName.Name = "lblLectName";
            this.lblLectName.Size = new System.Drawing.Size(198, 21);
            this.lblLectName.TabIndex = 1;
            this.lblLectName.Text = "Set By: Movasudevan Pillay";
            this.lblLectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLectName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseClick);
            this.lblLectName.MouseEnter += new System.EventHandler(this.pnMenu_MouseEnter);
            this.lblLectName.MouseLeave += new System.EventHandler(this.pnMenu_MouseLeave);
            // 
            // picMenuIcon
            // 
            this.picMenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("picMenuIcon.Image")));
            this.picMenuIcon.Location = new System.Drawing.Point(6, 10);
            this.picMenuIcon.Name = "picMenuIcon";
            this.picMenuIcon.Size = new System.Drawing.Size(115, 135);
            this.picMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuIcon.TabIndex = 0;
            this.picMenuIcon.TabStop = false;
            this.picMenuIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseClick);
            this.picMenuIcon.MouseEnter += new System.EventHandler(this.pnMenu_MouseEnter);
            this.picMenuIcon.MouseLeave += new System.EventHandler(this.pnMenu_MouseLeave);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.ForeColor = System.Drawing.Color.White;
            this.lblMarks.Location = new System.Drawing.Point(128, 94);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(114, 21);
            this.lblMarks.TabIndex = 1;
            this.lblMarks.Text = "Total Marks: 10";
            this.lblMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMarks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMenu_MouseClick);
            this.lblMarks.MouseEnter += new System.EventHandler(this.pnMenu_MouseEnter);
            this.lblMarks.MouseLeave += new System.EventHandler(this.pnMenu_MouseLeave);
            // 
            // TestContentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.pnMenu);
            this.Name = "TestContentMenu";
            this.Size = new System.Drawing.Size(340, 160);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblNumQues;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblLectName;
        private System.Windows.Forms.PictureBox picMenuIcon;
        private System.Windows.Forms.Label lblMarks;
    }
}
