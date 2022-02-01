namespace DesktopTestApp
{
    partial class LecturerMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerMain));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnMenuList = new System.Windows.Forms.Panel();
            this.pnUsing = new System.Windows.Forms.Panel();
            this.pnSide = new System.Windows.Forms.Panel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTstDb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTstVwr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStuRs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTestEditor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnUser = new System.Windows.Forms.Panel();
            this.picBxUser = new System.Windows.Forms.PictureBox();
            this.lblLectName = new System.Windows.Forms.Label();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picBxExit = new System.Windows.Forms.PictureBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.logoutTab1 = new DesktopTestApp.Lecturer_Components.LogoutTab();
            this.myAccountTab1 = new DesktopTestApp.Lecturer_Components.MyAccountTab();
            this.studentResultsTab1 = new DesktopTestApp.Lecturer_Components.StudentResultsTab();
            this.testDatabaseTab1 = new DesktopTestApp.Lecturer_Components.TestDatabaseTab();
            this.listTestTab1 = new DesktopTestApp.Lecturer_Components.Test_Viewer_Components.ListTestTab();
            this.addTestTab1 = new DesktopTestApp.Lecturer_Components.Test_Editor_Components.AddTestTab();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnMenuList.SuspendLayout();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUser)).BeginInit();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxExit)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Crimson;
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(800, 10);
            this.pnHeader.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnMenuList
            // 
            this.pnMenuList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.pnMenuList.Controls.Add(this.pnUsing);
            this.pnMenuList.Controls.Add(this.pnSide);
            this.pnMenuList.Controls.Add(this.btnLogout);
            this.pnMenuList.Controls.Add(this.btnTstDb);
            this.pnMenuList.Controls.Add(this.btnAccount);
            this.pnMenuList.Controls.Add(this.btnTstVwr);
            this.pnMenuList.Controls.Add(this.btnStuRs);
            this.pnMenuList.Controls.Add(this.btnTestEditor);
            this.pnMenuList.Controls.Add(this.pnUser);
            this.pnMenuList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuList.Location = new System.Drawing.Point(0, 10);
            this.pnMenuList.Name = "pnMenuList";
            this.pnMenuList.Size = new System.Drawing.Size(226, 460);
            this.pnMenuList.TabIndex = 1;
            // 
            // pnUsing
            // 
            this.pnUsing.BackColor = System.Drawing.Color.Crimson;
            this.pnUsing.ForeColor = System.Drawing.Color.Crimson;
            this.pnUsing.Location = new System.Drawing.Point(0, 66);
            this.pnUsing.Name = "pnUsing";
            this.pnUsing.Size = new System.Drawing.Size(10, 65);
            this.pnUsing.TabIndex = 3;
            // 
            // pnSide
            // 
            this.pnSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.pnSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSide.Location = new System.Drawing.Point(0, 66);
            this.pnSide.Name = "pnSide";
            this.pnSide.Size = new System.Drawing.Size(7, 394);
            this.pnSide.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = " Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 90D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(7, 392);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(219, 65);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTstDb
            // 
            this.btnTstDb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnTstDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnTstDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTstDb.BorderRadius = 0;
            this.btnTstDb.ButtonText = " Test Database";
            this.btnTstDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTstDb.DisabledColor = System.Drawing.Color.Gray;
            this.btnTstDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTstDb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnTstDb.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTstDb.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTstDb.Iconimage")));
            this.btnTstDb.Iconimage_right = null;
            this.btnTstDb.Iconimage_right_Selected = null;
            this.btnTstDb.Iconimage_Selected = null;
            this.btnTstDb.IconMarginLeft = 0;
            this.btnTstDb.IconMarginRight = 0;
            this.btnTstDb.IconRightVisible = true;
            this.btnTstDb.IconRightZoom = 0D;
            this.btnTstDb.IconVisible = true;
            this.btnTstDb.IconZoom = 90D;
            this.btnTstDb.IsTab = false;
            this.btnTstDb.Location = new System.Drawing.Point(7, 197);
            this.btnTstDb.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnTstDb.Name = "btnTstDb";
            this.btnTstDb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnTstDb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnTstDb.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTstDb.selected = false;
            this.btnTstDb.Size = new System.Drawing.Size(219, 65);
            this.btnTstDb.TabIndex = 1;
            this.btnTstDb.Text = " Test Database";
            this.btnTstDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTstDb.Textcolor = System.Drawing.Color.White;
            this.btnTstDb.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTstDb.Click += new System.EventHandler(this.btnTstDb_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccount.BorderRadius = 0;
            this.btnAccount.ButtonText = " My Account";
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccount.Iconimage")));
            this.btnAccount.Iconimage_right = null;
            this.btnAccount.Iconimage_right_Selected = null;
            this.btnAccount.Iconimage_Selected = null;
            this.btnAccount.IconMarginLeft = 0;
            this.btnAccount.IconMarginRight = 0;
            this.btnAccount.IconRightVisible = true;
            this.btnAccount.IconRightZoom = 0D;
            this.btnAccount.IconVisible = true;
            this.btnAccount.IconZoom = 90D;
            this.btnAccount.IsTab = false;
            this.btnAccount.Location = new System.Drawing.Point(7, 327);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnAccount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccount.selected = false;
            this.btnAccount.Size = new System.Drawing.Size(219, 65);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = " My Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Textcolor = System.Drawing.Color.White;
            this.btnAccount.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnTstVwr
            // 
            this.btnTstVwr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnTstVwr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnTstVwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTstVwr.BorderRadius = 0;
            this.btnTstVwr.ButtonText = " Test Viewer";
            this.btnTstVwr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTstVwr.DisabledColor = System.Drawing.Color.Gray;
            this.btnTstVwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTstVwr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnTstVwr.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTstVwr.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTstVwr.Iconimage")));
            this.btnTstVwr.Iconimage_right = null;
            this.btnTstVwr.Iconimage_right_Selected = null;
            this.btnTstVwr.Iconimage_Selected = null;
            this.btnTstVwr.IconMarginLeft = 0;
            this.btnTstVwr.IconMarginRight = 0;
            this.btnTstVwr.IconRightVisible = true;
            this.btnTstVwr.IconRightZoom = 0D;
            this.btnTstVwr.IconVisible = true;
            this.btnTstVwr.IconZoom = 90D;
            this.btnTstVwr.IsTab = false;
            this.btnTstVwr.Location = new System.Drawing.Point(7, 132);
            this.btnTstVwr.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnTstVwr.Name = "btnTstVwr";
            this.btnTstVwr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnTstVwr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnTstVwr.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTstVwr.selected = false;
            this.btnTstVwr.Size = new System.Drawing.Size(219, 65);
            this.btnTstVwr.TabIndex = 1;
            this.btnTstVwr.Text = " Test Viewer";
            this.btnTstVwr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTstVwr.Textcolor = System.Drawing.Color.White;
            this.btnTstVwr.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTstVwr.Click += new System.EventHandler(this.btnTstVwr_Click);
            // 
            // btnStuRs
            // 
            this.btnStuRs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnStuRs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnStuRs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStuRs.BorderRadius = 0;
            this.btnStuRs.ButtonText = " Student Results";
            this.btnStuRs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStuRs.DisabledColor = System.Drawing.Color.Gray;
            this.btnStuRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuRs.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnStuRs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStuRs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStuRs.Iconimage")));
            this.btnStuRs.Iconimage_right = null;
            this.btnStuRs.Iconimage_right_Selected = null;
            this.btnStuRs.Iconimage_Selected = null;
            this.btnStuRs.IconMarginLeft = 0;
            this.btnStuRs.IconMarginRight = 0;
            this.btnStuRs.IconRightVisible = true;
            this.btnStuRs.IconRightZoom = 0D;
            this.btnStuRs.IconVisible = true;
            this.btnStuRs.IconZoom = 90D;
            this.btnStuRs.IsTab = false;
            this.btnStuRs.Location = new System.Drawing.Point(7, 262);
            this.btnStuRs.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnStuRs.Name = "btnStuRs";
            this.btnStuRs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnStuRs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnStuRs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStuRs.selected = false;
            this.btnStuRs.Size = new System.Drawing.Size(219, 65);
            this.btnStuRs.TabIndex = 1;
            this.btnStuRs.Text = " Student Results";
            this.btnStuRs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuRs.Textcolor = System.Drawing.Color.White;
            this.btnStuRs.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuRs.Click += new System.EventHandler(this.btnStuRs_Click);
            // 
            // btnTestEditor
            // 
            this.btnTestEditor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnTestEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnTestEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTestEditor.BorderRadius = 0;
            this.btnTestEditor.ButtonText = " Test Editor";
            this.btnTestEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestEditor.DisabledColor = System.Drawing.Color.Gray;
            this.btnTestEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestEditor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnTestEditor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTestEditor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTestEditor.Iconimage")));
            this.btnTestEditor.Iconimage_right = null;
            this.btnTestEditor.Iconimage_right_Selected = null;
            this.btnTestEditor.Iconimage_Selected = null;
            this.btnTestEditor.IconMarginLeft = 0;
            this.btnTestEditor.IconMarginRight = 0;
            this.btnTestEditor.IconRightVisible = true;
            this.btnTestEditor.IconRightZoom = 0D;
            this.btnTestEditor.IconVisible = true;
            this.btnTestEditor.IconZoom = 90D;
            this.btnTestEditor.IsTab = false;
            this.btnTestEditor.Location = new System.Drawing.Point(7, 67);
            this.btnTestEditor.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnTestEditor.Name = "btnTestEditor";
            this.btnTestEditor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnTestEditor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btnTestEditor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTestEditor.selected = false;
            this.btnTestEditor.Size = new System.Drawing.Size(219, 65);
            this.btnTestEditor.TabIndex = 1;
            this.btnTestEditor.Text = " Test Editor";
            this.btnTestEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestEditor.Textcolor = System.Drawing.Color.White;
            this.btnTestEditor.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestEditor.Click += new System.EventHandler(this.btnTestEditor_Click);
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.pnUser.Controls.Add(this.picBxUser);
            this.pnUser.Controls.Add(this.lblLectName);
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUser.Location = new System.Drawing.Point(0, 0);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(226, 66);
            this.pnUser.TabIndex = 0;
            // 
            // picBxUser
            // 
            this.picBxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBxUser.Image")));
            this.picBxUser.Location = new System.Drawing.Point(9, 15);
            this.picBxUser.Name = "picBxUser";
            this.picBxUser.Size = new System.Drawing.Size(40, 37);
            this.picBxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxUser.TabIndex = 1;
            this.picBxUser.TabStop = false;
            // 
            // lblLectName
            // 
            this.lblLectName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLectName.Location = new System.Drawing.Point(50, 23);
            this.lblLectName.Name = "lblLectName";
            this.lblLectName.Size = new System.Drawing.Size(170, 23);
            this.lblLectName.TabIndex = 0;
            this.lblLectName.Text = "Lecturer Name";
            // 
            // pnDisplay
            // 
            this.pnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.pnDisplay.Controls.Add(this.btnBack);
            this.pnDisplay.Controls.Add(this.btnPrint);
            this.pnDisplay.Controls.Add(this.picBxExit);
            this.pnDisplay.Controls.Add(this.labTitle);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDisplay.Location = new System.Drawing.Point(226, 10);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(574, 66);
            this.pnDisplay.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.Crimson;
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = " Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 40D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(412, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Crimson;
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(82, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = " Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.Crimson;
            this.btnPrint.BackColor = System.Drawing.Color.Crimson;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = " Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 50D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(492, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.Crimson;
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(40)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(82, 35);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = " Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // picBxExit
            // 
            this.picBxExit.Image = ((System.Drawing.Image)(resources.GetObject("picBxExit.Image")));
            this.picBxExit.Location = new System.Drawing.Point(544, 1);
            this.picBxExit.Name = "picBxExit";
            this.picBxExit.Size = new System.Drawing.Size(28, 28);
            this.picBxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxExit.TabIndex = 1;
            this.picBxExit.TabStop = false;
            this.picBxExit.Click += new System.EventHandler(this.picBxExit_Click);
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.labTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTitle.Location = new System.Drawing.Point(1, 32);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(574, 35);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Add A Test To The Database";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.logoutTab1);
            this.MenuPanel.Controls.Add(this.myAccountTab1);
            this.MenuPanel.Controls.Add(this.studentResultsTab1);
            this.MenuPanel.Controls.Add(this.testDatabaseTab1);
            this.MenuPanel.Controls.Add(this.listTestTab1);
            this.MenuPanel.Controls.Add(this.addTestTab1);
            this.MenuPanel.Location = new System.Drawing.Point(226, 76);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(574, 394);
            this.MenuPanel.TabIndex = 3;
            // 
            // logoutTab1
            // 
            this.logoutTab1.Location = new System.Drawing.Point(0, 0);
            this.logoutTab1.Name = "logoutTab1";
            this.logoutTab1.Size = new System.Drawing.Size(574, 394);
            this.logoutTab1.TabIndex = 5;
            // 
            // myAccountTab1
            // 
            this.myAccountTab1.Location = new System.Drawing.Point(0, 0);
            this.myAccountTab1.Name = "myAccountTab1";
            this.myAccountTab1.Size = new System.Drawing.Size(574, 394);
            this.myAccountTab1.TabIndex = 4;
            // 
            // studentResultsTab1
            // 
            this.studentResultsTab1.AutoScroll = true;
            this.studentResultsTab1.AutoSize = true;
            this.studentResultsTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.studentResultsTab1.Location = new System.Drawing.Point(0, 0);
            this.studentResultsTab1.Name = "studentResultsTab1";
            this.studentResultsTab1.Size = new System.Drawing.Size(577, 394);
            this.studentResultsTab1.TabIndex = 3;
            // 
            // testDatabaseTab1
            // 
            this.testDatabaseTab1.BackColor = System.Drawing.SystemColors.Control;
            this.testDatabaseTab1.Location = new System.Drawing.Point(0, 0);
            this.testDatabaseTab1.Name = "testDatabaseTab1";
            this.testDatabaseTab1.Size = new System.Drawing.Size(574, 394);
            this.testDatabaseTab1.TabIndex = 2;
            // 
            // listTestTab1
            // 
            this.listTestTab1.BackColor = System.Drawing.SystemColors.Menu;
            this.listTestTab1.Location = new System.Drawing.Point(0, 0);
            this.listTestTab1.Name = "listTestTab1";
            this.listTestTab1.Size = new System.Drawing.Size(574, 394);
            this.listTestTab1.TabIndex = 1;
            // 
            // addTestTab1
            // 
            this.addTestTab1.Location = new System.Drawing.Point(0, 0);
            this.addTestTab1.Name = "addTestTab1";
            this.addTestTab1.Size = new System.Drawing.Size(574, 394);
            this.addTestTab1.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnDisplay;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LecturerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.pnMenuList);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerMain";
            this.pnMenuList.ResumeLayout(false);
            this.pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxUser)).EndInit();
            this.pnDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxExit)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnMenuList;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Panel pnSide;
        private Bunifu.Framework.UI.BunifuFlatButton btnTestEditor;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnTstDb;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccount;
        private Bunifu.Framework.UI.BunifuFlatButton btnTstVwr;
        private Bunifu.Framework.UI.BunifuFlatButton btnStuRs;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Panel pnUsing;
        private System.Windows.Forms.PictureBox picBxUser;
        private System.Windows.Forms.Label lblLectName;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.PictureBox picBxExit;
        private System.Windows.Forms.Panel MenuPanel;
        private Lecturer_Components.Test_Editor_Components.AddTestTab addTestTab1;
        private Lecturer_Components.Test_Viewer_Components.ListTestTab listTestTab1;
        private Lecturer_Components.LogoutTab logoutTab1;
        private Lecturer_Components.MyAccountTab myAccountTab1;
        private Lecturer_Components.StudentResultsTab studentResultsTab1;
        private Lecturer_Components.TestDatabaseTab testDatabaseTab1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}