using System.Drawing;

namespace DesktopTestApp.Lecturer_Components
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentResultsTab));
            this.pnCalc = new System.Windows.Forms.Panel();
            this.lblLowMark = new System.Windows.Forms.Label();
            this.lblHighMark = new System.Windows.Forms.Label();
            this.lblTotStud = new System.Windows.Forms.Label();
            this.lblClsAvg = new System.Windows.Forms.Label();
            this.lvStudRes = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCalc
            // 
            this.pnCalc.BackColor = System.Drawing.Color.Crimson;
            this.pnCalc.Controls.Add(this.lblLowMark);
            this.pnCalc.Controls.Add(this.lblHighMark);
            this.pnCalc.Controls.Add(this.lblTotStud);
            this.pnCalc.Controls.Add(this.lblClsAvg);
            resources.ApplyResources(this.pnCalc, "pnCalc");
            this.pnCalc.Name = "pnCalc";
            // 
            // lblLowMark
            // 
            resources.ApplyResources(this.lblLowMark, "lblLowMark");
            this.lblLowMark.ForeColor = System.Drawing.Color.White;
            this.lblLowMark.Name = "lblLowMark";
            // 
            // lblHighMark
            // 
            resources.ApplyResources(this.lblHighMark, "lblHighMark");
            this.lblHighMark.ForeColor = System.Drawing.Color.White;
            this.lblHighMark.Name = "lblHighMark";
            // 
            // lblTotStud
            // 
            resources.ApplyResources(this.lblTotStud, "lblTotStud");
            this.lblTotStud.ForeColor = System.Drawing.Color.White;
            this.lblTotStud.Name = "lblTotStud";
            // 
            // lblClsAvg
            // 
            resources.ApplyResources(this.lblClsAvg, "lblClsAvg");
            this.lblClsAvg.ForeColor = System.Drawing.Color.White;
            this.lblClsAvg.Name = "lblClsAvg";
            // 
            // lvStudRes
            // 
            this.lvStudRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvStudRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvStudRes.Depth = 0;
            resources.ApplyResources(this.lvStudRes, "lvStudRes");
            this.lvStudRes.FullRowSelect = true;
            this.lvStudRes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStudRes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvStudRes.MouseState = MaterialSkin.MouseState.OUT;
            this.lvStudRes.Name = "lvStudRes";
            this.lvStudRes.OwnerDraw = true;
            this.lvStudRes.UseCompatibleStateImageBehavior = false;
            this.lvStudRes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // StudentResultsTab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lvStudRes);
            this.Controls.Add(this.pnCalc);
            this.Name = "StudentResultsTab";
            this.pnCalc.ResumeLayout(false);
            this.pnCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnCalc;
        private System.Windows.Forms.Label lblLowMark;
        private System.Windows.Forms.Label lblHighMark;
        private System.Windows.Forms.Label lblTotStud;
        private System.Windows.Forms.Label lblClsAvg;
        private MaterialSkin.Controls.MaterialListView lvStudRes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
