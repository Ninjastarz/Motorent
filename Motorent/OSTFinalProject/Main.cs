﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modals;
namespace OSTFinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<Vehicle> VehicleList = new List<Vehicle>();

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm f1 = new AddVehicleForm();
            this.Hide();
            f1.Show();
        }

        private void BtnAddJourney_Click(object sender, EventArgs e)
        {
            RegisterJourneyForm f1 = new RegisterJourneyForm();
            this.Hide();
            f1.Show();
        }
    }
}
