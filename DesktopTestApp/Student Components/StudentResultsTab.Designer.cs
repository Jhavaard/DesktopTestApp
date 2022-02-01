namespace DesktopTestApp.Student_Components
{
    partial class StudentResultsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentResultsTab));
            this.colLectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStdScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStdTot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStdMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStdResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MnItemLectLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnItemGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnItemExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picExitApp = new System.Windows.Forms.PictureBox();
            this.lvStdRes = new MaterialSkin.Controls.MaterialListView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExitApp)).BeginInit();
            this.SuspendLayout();
            // 
            // colLectName
            // 
            this.colLectName.Text = "Lecturer";
            this.colLectName.Width = 139;
            // 
            // colTestName
            // 
            this.colTestName.Text = "Test";
            this.colTestName.Width = 139;
            // 
            // colStdScore
            // 
            this.colStdScore.Text = "Your Score";
            this.colStdScore.Width = 139;
            // 
            // colStdTot
            // 
            this.colStdTot.Text = "Test Total";
            this.colStdTot.Width = 139;
            // 
            // colStdMark
            // 
            this.colStdMark.Text = "Your Mark(%)";
            this.colStdMark.Width = 139;
            // 
            // colStdResult
            // 
            this.colStdResult.Text = "Result";
            this.colStdResult.Width = 139;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MnItemLectLogin
            // 
            this.MnItemLectLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.MnItemLectLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MnItemLectLogin.ForeColor = System.Drawing.Color.White;
            this.MnItemLectLogin.Image = ((System.Drawing.Image)(resources.GetObject("MnItemLectLogin.Image")));
            this.MnItemLectLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnItemLectLogin.Name = "MnItemLectLogin";
            this.MnItemLectLogin.Size = new System.Drawing.Size(202, 42);
            this.MnItemLectLogin.Text = "Lecturer Login";
            this.MnItemLectLogin.Click += new System.EventHandler(this.MnItemLectLogin_Click);
            // 
            // StripSep2
            // 
            this.StripSep2.AutoSize = false;
            this.StripSep2.Name = "StripSep2";
            this.StripSep2.Size = new System.Drawing.Size(199, 1);
            // 
            // MnItemGoBack
            // 
            this.MnItemGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.MnItemGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MnItemGoBack.ForeColor = System.Drawing.Color.White;
            this.MnItemGoBack.Image = ((System.Drawing.Image)(resources.GetObject("MnItemGoBack.Image")));
            this.MnItemGoBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnItemGoBack.Name = "MnItemGoBack";
            this.MnItemGoBack.Size = new System.Drawing.Size(202, 42);
            this.MnItemGoBack.Text = "Go Back";
            this.MnItemGoBack.Click += new System.EventHandler(this.MnItemGoBack_Click);
            // 
            // StripSep1
            // 
            this.StripSep1.AutoSize = false;
            this.StripSep1.Name = "StripSep1";
            this.StripSep1.Size = new System.Drawing.Size(199, 1);
            // 
            // MnItemExitApp
            // 
            this.MnItemExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.MnItemExitApp.ForeColor = System.Drawing.Color.White;
            this.MnItemExitApp.Image = ((System.Drawing.Image)(resources.GetObject("MnItemExitApp.Image")));
            this.MnItemExitApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnItemExitApp.Name = "MnItemExitApp";
            this.MnItemExitApp.Size = new System.Drawing.Size(202, 42);
            this.MnItemExitApp.Text = "Exit Application";
            this.MnItemExitApp.Click += new System.EventHandler(this.MnItemExitApp_Click);
            // 
            // menuImage
            // 
            this.menuImage.AutoSize = false;
            this.menuImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.menuImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnItemExitApp,
            this.StripSep1,
            this.MnItemGoBack,
            this.StripSep2,
            this.MnItemLectLogin});
            this.menuImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuImage.Image = ((System.Drawing.Image)(resources.GetObject("menuImage.Image")));
            this.menuImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(30, 29);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.Green;
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.Green;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleForecolor = System.Drawing.Color.White;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(767, 628);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 35);
            this.btnClose.TabIndex = 32;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Menu";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Result";
            this.columnHeader1.Width = 139;
            // 
            // menuOptions
            // 
            this.menuOptions.AutoSize = false;
            this.menuOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.menuOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage});
            this.menuOptions.Location = new System.Drawing.Point(14, 10);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(40, 34);
            this.menuOptions.TabIndex = 30;
            this.menuOptions.Text = "menuStrip1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Your Mark(%)";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Test Total";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Your Score";
            this.columnHeader4.Width = 139;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Test";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lecturer";
            this.columnHeader6.Width = 139;
            // 
            // picExitApp
            // 
            this.picExitApp.Image = ((System.Drawing.Image)(resources.GetObject("picExitApp.Image")));
            this.picExitApp.Location = new System.Drawing.Point(895, 16);
            this.picExitApp.Name = "picExitApp";
            this.picExitApp.Size = new System.Drawing.Size(30, 30);
            this.picExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExitApp.TabIndex = 29;
            this.picExitApp.TabStop = false;
            this.picExitApp.Click += new System.EventHandler(this.picExitApp_Click);
            // 
            // lvStdRes
            // 
            this.lvStdRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.lvStdRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvStdRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader1});
            this.lvStdRes.Depth = 0;
            this.lvStdRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvStdRes.FullRowSelect = true;
            this.lvStdRes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStdRes.Location = new System.Drawing.Point(57, 127);
            this.lvStdRes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvStdRes.MouseState = MaterialSkin.MouseState.OUT;
            this.lvStdRes.Name = "lvStdRes";
            this.lvStdRes.OwnerDraw = true;
            this.lvStdRes.Size = new System.Drawing.Size(834, 473);
            this.lvStdRes.TabIndex = 28;
            this.lvStdRes.UseCompatibleStateImageBehavior = false;
            this.lvStdRes.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Showing All Your Test Results";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StudentResultsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuOptions);
            this.Controls.Add(this.picExitApp);
            this.Controls.Add(this.lvStdRes);
            this.Controls.Add(this.label1);
            this.Name = "StudentResultsTab";
            this.Size = new System.Drawing.Size(939, 686);
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExitApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader colLectName;
        private System.Windows.Forms.ColumnHeader colTestName;
        private System.Windows.Forms.ColumnHeader colStdScore;
        private System.Windows.Forms.ColumnHeader colStdTot;
        private System.Windows.Forms.ColumnHeader colStdMark;
        private System.Windows.Forms.ColumnHeader colStdResult;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem MnItemExitApp;
        private System.Windows.Forms.ToolStripSeparator StripSep1;
        private System.Windows.Forms.ToolStripMenuItem MnItemGoBack;
        private System.Windows.Forms.ToolStripSeparator StripSep2;
        private System.Windows.Forms.ToolStripMenuItem MnItemLectLogin;
        private System.Windows.Forms.PictureBox picExitApp;
        private MaterialSkin.Controls.MaterialListView lvStdRes;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
    }
}
