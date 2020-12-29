using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_project
{
    public partial class Elevator : Form
    {
        bool go_up = false;
        bool go_down = false;

        bool arrived_G = false;
        bool arrived_1 = false;

        public Elevator()
        {
            InitializeComponent();
        }

        private void Elevator_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
