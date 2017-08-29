using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Form_App
{
    public partial class CINEMA : Form
    {
        public CINEMA()
        {
            InitializeComponent();
        }

       private void hall1_Click(object sender, EventArgs e)
        {
            Hall_1 hall1 = new Hall_1();
            hall1.Owner = this;
            hall1.Show();
        }

        private void hall2_Click(object sender, EventArgs e)
        {
            Hall_2 hall2 = new Hall_2();
            hall2.Owner = this;
            hall2.Show();
        }

        private void hall3_Click(object sender, EventArgs e)
        {
            Hall_3 hall3 = new Hall_3();
            hall3.Owner = this;
            hall3.Show();
        }
    
    }
}
