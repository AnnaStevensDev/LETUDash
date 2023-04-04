using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LETUDashProto
{
    public partial class letuDashPrototype : Form
    {
        public letuDashPrototype()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            feedsScreenPanel.Dock = DockStyle.Fill;
            homeScreenPanel.Dock = DockStyle.Fill;
            businessHoursPanel.Dock = DockStyle.Fill;
            feedsScreenPanel.Visible = false;
            businessHoursPanel.Visible = false;
            homeScreenPanel.Visible = true;
            
            
        }

        private void takeMeHomeButton_Click(object sender, EventArgs e)
        {
            feedsScreenPanel.Visible = false;
            businessHoursPanel.Visible = false;
            homeScreenPanel.Visible = true;
        }

        private void feedsListButton_Click(object sender, EventArgs e)
        {
            
            homeScreenPanel.Visible = false;
            feedsScreenPanel.Visible = true;
            businessHoursPanel.Visible = false;
            //MessageBox.Show("Event Handler has been run");
            
        }

        private void buildingHoursButton_Click_1(object sender, EventArgs e)
        {
            homeScreenPanel.Visible = false;
            feedsScreenPanel.Visible = false;
            businessHoursPanel.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            homeScreenPanel.Visible = false;
            feedsScreenPanel.Visible = true;
            businessHoursPanel.Visible = false;
        }

        private void addFeedButton_Click(object sender, EventArgs e)
        {
            feedsScreenPanel.Visible = false;
            businessHoursPanel.Visible = false;
            homeScreenPanel.Visible = true;
        }
    }
}
