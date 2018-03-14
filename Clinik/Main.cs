using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SC_Reg.FixedPanel = FixedPanel.Panel1;
            SC_Doctors.FixedPanel = FixedPanel.Panel1;

        }
        private void BTN_RemoveDoctor_Click(object sender, EventArgs e)
        {
            LB_Doctors.Items.Remove(LB_Doctors.SelectedItem);
        }
    }
}
