using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSTFinalProject
{
    public partial class RegisterJourneyForm : Form
    {
        public RegisterJourneyForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm f1 = new MainForm();
            this.Close();
            f1.Show();
        }
    }
}
