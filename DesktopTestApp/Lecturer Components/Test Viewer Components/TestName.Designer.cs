namespace DesktopTestApp.Lecturer_Components.Test_Viewer_Components
{
    partial class TestName
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
            this.chkBxTestSel = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblTstName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblQues = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // chkBxTestSel
            // 
            this.chkBxTestSel.Depth = 0;
            this.chkBxTestSel.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkBxTestSel.Location = new System.Drawing.Point(9, 0);
            this.chkBxTestSel.Margin = new System.Windows.Forms.Padding(0);
            this.chkBxTestSel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBxTestSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBxTestSel.Name = "chkBxTestSel";
            this.chkBxTestSel.Ripple = true;
            this.chkBxTestSel.Size = new System.Drawing.Size(30, 30);
            this.chkBxTestSel.TabIndex = 6;
            this.chkBxTestSel.Text = "Maths Test";
            this.chkBxTestSel.UseVisualStyleBackColor = true;
            this.chkBxTestSel.CheckedChanged += new System.EventHandler(this.chkBxTestSel_CheckedChanged);
            // 
            // lblTstName
            // 
            this.lblTstName.AutoSize = true;
            this.lblTstName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTstName.Location = new System.Drawing.Point(46, 4);
            this.lblTstName.Name = "lblTstName";
            this.lblTstName.Size = new System.Drawing.Size(80, 20);
            this.lblTstName.TabIndex = 7;
            this.lblTstName.Text = "Maths Test";
            this.lblTstName.MouseEnter += new System.EventHandler(this.lblTstName_MouseEnter);
            this.lblTstName.MouseLeave += new System.EventHandler(this.lblTstName_MouseLeave);
            // 
            // lblQues
            // 
            this.lblQues.AutoSize = true;
            this.lblQues.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQues.Location = new System.Drawing.Point(294, 4);
            this.lblQues.Name = "lblQues";
            this.lblQues.Size = new System.Drawing.Size(94, 20);
            this.lblQues.TabIndex = 7;
            this.lblQues.Text = "17 Questions";
            this.lblQues.MouseEnter += new System.EventHandler(this.lblQues_MouseEnter);
            this.lblQues.MouseLeave += new System.EventHandler(this.lblQues_MouseLeave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(453, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "17/03/2017";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.MouseEnter += new System.EventHandler(this.lblDate_MouseEnter);
            this.lblDate.MouseLeave += new System.EventHandler(this.lblDate_MouseLeave);
            // 
            // TestName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblQues);
            this.Controls.Add(this.lblTstName);
            this.Controls.Add(this.chkBxTestSel);
            this.Name = "TestName";
            this.Size = new System.Drawing.Size(574, 30);
            this.MouseEnter += new System.EventHandler(this.TestName_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TestName_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox chkBxTestSel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTstName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQues;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDate;
    }
}
