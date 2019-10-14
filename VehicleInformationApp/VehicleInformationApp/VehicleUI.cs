using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleInformationApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
        }
        Vehicle aVehicle = new Vehicle();
        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle.VehicleName = nameTextBox.Text;
            aVehicle.RegNo = regNoTextBox.Text;
            MessageBox.Show("Vehicle saved successfully");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double speed = Convert.ToDouble(speedTextBox.Text);
            aVehicle.Speeds.Add(speed);
            showButton.Enabled = true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            minSpeedTextBox.Text = aVehicle.GetMinSpeed().ToString();
            maxSpeedTextBox.Text = aVehicle.GetMaxSpeed().ToString();
            avgSpeedTextBox.Text = aVehicle.GetAvgSpeed().ToString();
        }
    }
}
