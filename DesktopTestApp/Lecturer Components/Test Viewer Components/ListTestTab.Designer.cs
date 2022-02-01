namespace DesktopTestApp.Lecturer_Components.Test_Viewer_Components
{
    partial class ListTestTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTestTab));
            this.pnTest = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTestSel = new System.Windows.Forms.Label();
            this.pnListTst = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShell = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOpen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnTest.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTest
            // 
            this.pnTest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnTest.Controls.Add(this.panel2);
            this.pnTest.Controls.Add(this.pnListTst);
            this.pnTest.Controls.Add(this.label3);
            this.pnTest.Controls.Add(this.label2);
            this.pnTest.Controls.Add(this.label1);
            this.pnTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTest.Location = new System.Drawing.Point(0, 42);
            this.pnTest.Name = "pnTest";
            this.pnTest.Size = new System.Drawing.Size(574, 352);
            this.pnTest.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.lblTestSel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 21);
            this.panel2.TabIndex = 6;
            // 
            // lblTestSel
            // 
            this.lblTestSel.AutoSize = true;
            this.lblTestSel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestSel.ForeColor = System.Drawing.Color.White;
            this.lblTestSel.Location = new System.Drawing.Point(4, 1);
            this.lblTestSel.Name = "lblTestSel";
            this.lblTestSel.Size = new System.Drawing.Size(89, 17);
            this.lblTestSel.TabIndex = 0;
            this.lblTestSel.Text = "Test Selected:";
            // 
            // pnListTst
            // 
            this.pnListTst.BackColor = System.Drawing.SystemColors.Control;
            this.pnListTst.Location = new System.Drawing.Point(1, 26);
            this.pnListTst.Name = "pnListTst";
            this.pnListTst.Size = new System.Drawing.Size(574, 307);
            this.pnListTst.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(452, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(295, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Questions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(47, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test Name";
            // 
            // txtShell
            // 
            this.txtShell.BackColor = System.Drawing.Color.Crimson;
            this.txtShell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtShell.BackgroundImage")));
            this.txtShell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtShell.ForeColor = System.Drawing.Color.White;
            this.txtShell.Icon = ((System.Drawing.Image)(resources.GetObject("txtShell.Icon")));
            this.txtShell.Location = new System.Drawing.Point(260, 7);
            this.txtShell.Margin = new System.Windows.Forms.Padding(0);
            this.txtShell.Name = "txtShell";
            this.txtShell.Size = new System.Drawing.Size(300, 32);
            this.txtShell.TabIndex = 0;
            this.txtShell.text = "Bunifu TextBox";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.txtShell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 46);
            this.panel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Crimson;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.Location = new System.Drawing.Point(299, 11);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search Test By Name";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnOpen
            // 
            this.btnOpen.Activecolor = System.Drawing.Color.Crimson;
            this.btnOpen.BackColor = System.Drawing.Color.Crimson;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.BorderRadius = 0;
            this.btnOpen.ButtonText = "Open test";
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOpen.Iconimage")));
            this.btnOpen.Iconimage_right = null;
            this.btnOpen.Iconimage_right_Selected = null;
            this.btnOpen.Iconimage_Selected = null;
            this.btnOpen.IconMarginLeft = 0;
            this.btnOpen.IconMarginRight = 0;
            this.btnOpen.IconRightVisible = true;
            this.btnOpen.IconRightZoom = 0D;
            this.btnOpen.IconVisible = true;
            this.btnOpen.IconZoom = 60D;
            this.btnOpen.IsTab = false;
            this.btnOpen.Location = new System.Drawing.Point(126, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Normalcolor = System.Drawing.Color.Crimson;
            this.btnOpen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOpen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpen.selected = false;
            this.btnOpen.Size = new System.Drawing.Size(116, 36);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open test";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Textcolor = System.Drawing.Color.White;
            this.btnOpen.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnTest
            // 
            this.btnTest.Activecolor = System.Drawing.Color.Crimson;
            this.btnTest.BackColor = System.Drawing.Color.Crimson;
            this.btnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTest.BorderRadius = 0;
            this.btnTest.ButtonText = "View Test";
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.DisabledColor = System.Drawing.Color.Gray;
            this.btnTest.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTest.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTest.Iconimage")));
            this.btnTest.Iconimage_right = null;
            this.btnTest.Iconimage_right_Selected = null;
            this.btnTest.Iconimage_Selected = null;
            this.btnTest.IconMarginLeft = 0;
            this.btnTest.IconMarginRight = 0;
            this.btnTest.IconRightVisible = true;
            this.btnTest.IconRightZoom = 0D;
            this.btnTest.IconVisible = true;
            this.btnTest.IconZoom = 60D;
            this.btnTest.IsTab = false;
            this.btnTest.Location = new System.Drawing.Point(7, 5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Normalcolor = System.Drawing.Color.Crimson;
            this.btnTest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTest.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTest.selected = false;
            this.btnTest.Size = new System.Drawing.Size(116, 36);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "View Test";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Textcolor = System.Drawing.Color.White;
            this.btnTest.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ListTestTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTest);
            this.Name = "ListTestTab";
            this.Size = new System.Drawing.Size(574, 394);
            this.pnTest.ResumeLayout(false);
            this.pnTest.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTest;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpen;
        private Bunifu.Framework.UI.BunifuFlatButton btnTest;
        private Bunifu.Framework.UI.BunifuTextbox txtShell;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnListTst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTestSel;
    }
}
