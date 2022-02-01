namespace DesktopTestApp.Lecturer_Components
{
    partial class TestDatabaseTab
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
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.Col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Questioner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_NoQues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Taken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Passed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Failed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Name,
            this.Col_Questioner,
            this.Col_Created,
            this.Col_NoQues,
            this.Col_Total,
            this.Col_Taken,
            this.Col_Passed,
            this.Col_Failed});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(574, 374);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // Col_Name
            // 
            this.Col_Name.Text = "Test Name";
            this.Col_Name.Width = 130;
            // 
            // Col_Questioner
            // 
            this.Col_Questioner.Text = "Questioner";
            this.Col_Questioner.Width = 150;
            // 
            // Col_Created
            // 
            this.Col_Created.Text = "Created";
            this.Col_Created.Width = 130;
            // 
            // Col_NoQues
            // 
            this.Col_NoQues.Text = "Questions";
            this.Col_NoQues.Width = 100;
            // 
            // Col_Total
            // 
            this.Col_Total.Text = "Test Total";
            this.Col_Total.Width = 90;
            // 
            // Col_Taken
            // 
            this.Col_Taken.Text = "No. Taken";
            this.Col_Taken.Width = 90;
            // 
            // Col_Passed
            // 
            this.Col_Passed.Text = "No. Passed";
            this.Col_Passed.Width = 100;
            // 
            // Col_Failed
            // 
            this.Col_Failed.Text = "No. Failed";
            this.Col_Failed.Width = 100;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Crimson;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(259, 1);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 17);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 21);
            this.panel1.TabIndex = 2;
            // 
            // TestDatabaseTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialListView1);
            this.Name = "TestDatabaseTab";
            this.Size = new System.Drawing.Size(574, 394);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader Col_Name;
        private System.Windows.Forms.ColumnHeader Col_Questioner;
        private System.Windows.Forms.ColumnHeader Col_Created;
        private System.Windows.Forms.ColumnHeader Col_NoQues;
        private System.Windows.Forms.ColumnHeader Col_Total;
        private System.Windows.Forms.ColumnHeader Col_Taken;
        private System.Windows.Forms.ColumnHeader Col_Passed;
        private System.Windows.Forms.ColumnHeader Col_Failed;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel panel1;
    }
}
