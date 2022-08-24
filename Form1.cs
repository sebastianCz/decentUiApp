using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplicationLocalOnly
{
    public partial class Form1 : Form
    {


       
            

        //Onload nav functions
        public Form1()
        {
        
            InitializeComponent();
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(135, 206, 235);
            btnAnalytics.BackColor = Color.FromArgb(30, 144, 255);
            btnCalendar.BackColor = Color.FromArgb(30, 144, 255);
            btnContactUs.BackColor = Color.FromArgb(30, 144, 255);
            btnSettings.BackColor = Color.FromArgb(30, 144, 255);
            panel6.BackColor = Color.FromArgb(176, 224, 230);
            panel5.BackColor = Color.FromArgb(176, 224, 230);
            panel4.BackColor = Color.FromArgb(176, 224, 230);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(30, 144, 255);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(135, 206, 235);
        }

        //On click nav functions 
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top; 
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(135, 206, 235);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(135, 206, 235);

        }
        

        private void btnCalendar_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            pnlNav.Left = btnCalendar.Left;
            btnCalendar.BackColor = Color.FromArgb(135, 206, 235);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlNav.Left = btnContactUs.Left;
            btnContactUs.BackColor = Color.FromArgb(135, 206, 235);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlNav.Left = btnContactUs.Left;
            btnSettings.BackColor = Color.FromArgb(135, 206, 235);

        }

        //On leave nav functions

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(30, 144, 255);
        }
 

        private void btnAnalytics_Leave_1(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(30, 144, 255);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(30, 144, 255);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(30, 144, 255);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(30, 144, 255);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}


