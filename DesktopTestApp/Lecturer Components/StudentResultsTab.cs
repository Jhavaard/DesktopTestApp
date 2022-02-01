using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DesktopTestApp.Lecturer_Components;

namespace DesktopTestApp.Lecturer_Components
{
    public partial class StudentResultsTab : UserControl
    {
        public static StudentResultsTab StudResTbObj;
        public Boolean canCall = true;

        public StudentResultsTab()
        {
            InitializeComponent();
            StudResTbObj = this;
        }

        public void callSelectTestTab()
        {
            if (canCall == true)
            {
                canCall = false;
                SelectTestTab SelTestObj = new SelectTestTab();
                pnCalc.Visible = false;
                this.Controls.Add(SelTestObj);
                SelTestObj.populateListBox();
                SelTestObj.BringToFront();
            }
        }

        public void pnCalcVisibleTrue()
        {
            pnCalc.Visible = true;
        }

        public void populateListView()
        {
            lvStudRes.Items.Clear();

            foreach (string[] readLine in DataBaseConn.TstFilObj.readAllStudRes(SelectTestTab.testName))
            {
                ListViewItem resultsList = new ListViewItem(readLine);
                lvStudRes.Items.Add(resultsList);
            }

            string[] calResults = DataBaseConn.TstFilObj.calAllStudRes(SelectTestTab.testName);

            lblTotStud.Text = "Total Students: " + calResults[0];
            lblClsAvg.Text = "Class Average: " + calResults[1];
            lblHighMark.Text = "Highest Mark: " + calResults[2] + "%";
            lblLowMark.Text = "Lowest Mark: " + calResults[3] + "%";
        }

        public void StartPrint()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.Print();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmapResults = new Bitmap(lvStudRes.Width, lvStudRes.Height);
            lvStudRes.DrawToBitmap(bitmapResults, lvStudRes.ClientRectangle);

            Bitmap bitmapCalc = new Bitmap(pnCalc.Width, pnCalc.Height);
            pnCalc.DrawToBitmap(bitmapCalc, pnCalc.ClientRectangle);

            Graphics graphics = e.Graphics;

            graphics.DrawString("Title: Student Marks Report\nDate : "+ DateTime.Now.ToString("yyyy:MM:dd")+"\nTime : "+ DateTime.Now.ToString("h:mm:ss tt"),
                     new Font("Courier New", 20),
                     new SolidBrush(Color.Lime), 50, 20);
            graphics.DrawImage(bitmapResults, new Point(50, 130));
            graphics.DrawImage(bitmapCalc, new Point(50, lvStudRes.Height+150));
        }
    }
}
