namespace DesktopTestApp.Lecturer_Components.Test_Editor_Components
{
    partial class QuestionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionMenu));
            this.btnView = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbQues = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageActive = null;
            this.btnView.Location = new System.Drawing.Point(4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(35, 29);
            this.btnView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnView.TabIndex = 1;
            this.btnView.TabStop = false;
            this.btnView.Zoom = 10;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCheckbox1.Location = new System.Drawing.Point(9, 10);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 4;
            // 
            // lbQues
            // 
            this.lbQues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQues.ForeColor = System.Drawing.Color.Black;
            this.lbQues.Location = new System.Drawing.Point(35, 8);
            this.lbQues.Name = "lbQues";
            this.lbQues.Size = new System.Drawing.Size(456, 21);
            this.lbQues.TabIndex = 3;
            this.lbQues.Text = "Question";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Location = new System.Drawing.Point(497, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 40);
            this.panel1.TabIndex = 5;
            // 
            // QuestionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.lbQues);
            this.Name = "QuestionMenu";
            this.Size = new System.Drawing.Size(540, 40);
            this.MouseEnter += new System.EventHandler(this.QuestionMenu_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.QuestionMenu_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnView;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        public System.Windows.Forms.Label lbQues;
        private System.Windows.Forms.Panel panel1;
    }
}
