namespace DesktopTestApp.Lecturer_Components.Test_Editor_Components
{
    partial class AddTestTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTestTab));
            this.pnAddTest = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTestName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnDelSelected = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddTest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnAddTest.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAddTest
            // 
            this.pnAddTest.Controls.Add(this.pnBottom);
            this.pnAddTest.Controls.Add(this.panel1);
            this.pnAddTest.Location = new System.Drawing.Point(0, 0);
            this.pnAddTest.Name = "pnAddTest";
            this.pnAddTest.Size = new System.Drawing.Size(574, 394);
            this.pnAddTest.TabIndex = 0;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Crimson;
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 371);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(574, 23);
            this.pnBottom.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.txtTestName);
            this.panel1.Controls.Add(this.btnDelSelected);
            this.panel1.Controls.Add(this.btnAddTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 10;
            // 
            // txtTestName
            // 
            this.txtTestName.BackColor = System.Drawing.Color.White;
            this.txtTestName.BorderColorFocused = System.Drawing.Color.White;
            this.txtTestName.BorderColorIdle = System.Drawing.Color.White;
            this.txtTestName.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtTestName.BorderThickness = 3;
            this.txtTestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTestName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestName.ForeColor = System.Drawing.Color.Gray;
            this.txtTestName.isPassword = false;
            this.txtTestName.Location = new System.Drawing.Point(9, 14);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(312, 25);
            this.txtTestName.TabIndex = 11;
            this.txtTestName.Text = "Enter Test Name";
            this.txtTestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTestName.Enter += new System.EventHandler(this.txtTestName_Enter);
            this.txtTestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTestName_KeyPress);
            this.txtTestName.Leave += new System.EventHandler(this.txtTestName_Leave);
            // 
            // btnDelSelected
            // 
            this.btnDelSelected.Activecolor = System.Drawing.Color.Crimson;
            this.btnDelSelected.BackColor = System.Drawing.Color.Crimson;
            this.btnDelSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelSelected.BorderRadius = 0;
            this.btnDelSelected.ButtonText = "Delete Selected";
            this.btnDelSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelSelected.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelSelected.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelSelected.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelSelected.Iconimage")));
            this.btnDelSelected.Iconimage_right = null;
            this.btnDelSelected.Iconimage_right_Selected = null;
            this.btnDelSelected.Iconimage_Selected = null;
            this.btnDelSelected.IconMarginLeft = 0;
            this.btnDelSelected.IconMarginRight = 0;
            this.btnDelSelected.IconRightVisible = true;
            this.btnDelSelected.IconRightZoom = 0D;
            this.btnDelSelected.IconVisible = true;
            this.btnDelSelected.IconZoom = 88D;
            this.btnDelSelected.IsTab = false;
            this.btnDelSelected.Location = new System.Drawing.Point(425, 1);
            this.btnDelSelected.Name = "btnDelSelected";
            this.btnDelSelected.Normalcolor = System.Drawing.Color.Crimson;
            this.btnDelSelected.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnDelSelected.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelSelected.selected = false;
            this.btnDelSelected.Size = new System.Drawing.Size(148, 48);
            this.btnDelSelected.TabIndex = 7;
            this.btnDelSelected.Text = "Delete Selected";
            this.btnDelSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSelected.Textcolor = System.Drawing.Color.White;
            this.btnDelSelected.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSelected.Click += new System.EventHandler(this.btnDelSelected_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Activecolor = System.Drawing.Color.Crimson;
            this.btnAddTest.BackColor = System.Drawing.Color.Crimson;
            this.btnAddTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTest.BorderRadius = 0;
            this.btnAddTest.ButtonText = "Add Test";
            this.btnAddTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTest.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTest.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTest.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddTest.Iconimage")));
            this.btnAddTest.Iconimage_right = null;
            this.btnAddTest.Iconimage_right_Selected = null;
            this.btnAddTest.Iconimage_Selected = null;
            this.btnAddTest.IconMarginLeft = 0;
            this.btnAddTest.IconMarginRight = 0;
            this.btnAddTest.IconRightVisible = true;
            this.btnAddTest.IconRightZoom = 0D;
            this.btnAddTest.IconVisible = true;
            this.btnAddTest.IconZoom = 80D;
            this.btnAddTest.IsTab = false;
            this.btnAddTest.Location = new System.Drawing.Point(322, 1);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Normalcolor = System.Drawing.Color.Crimson;
            this.btnAddTest.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnAddTest.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddTest.selected = false;
            this.btnAddTest.Size = new System.Drawing.Size(109, 48);
            this.btnAddTest.TabIndex = 7;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTest.Textcolor = System.Drawing.Color.White;
            this.btnAddTest.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.txtTestName;
            // 
            // AddTestTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAddTest);
            this.Name = "AddTestTab";
            this.Size = new System.Drawing.Size(574, 394);
            this.pnAddTest.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAddTest;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTestName;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelSelected;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddTest;
        private System.Windows.Forms.Panel pnBottom;
    }
}
