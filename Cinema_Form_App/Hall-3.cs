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
    public partial class Hall_3 : Form
    {
        public List<Button> yerler = new List<Button>();
        public Hall_3()
        {
            InitializeComponent();
        }
        int left = 100;
        int top = 100;
        int count = 1;
        private void Hall_3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                if (i == 12)
                {
                    left = 100;
                    top = 150;
                }
                else if (i == 24)
                {
                    left = 100;
                    top = 200;
                }
                else if (i == 36)
                {
                    left = 100;
                    top = 250;
                }
                else if (i == 48)
                {
                    left = 100;
                    top = 300;
                }
                else if (i == 60)
                {
                    left = 100;
                    top = 300;
                }
                Button yerler = new Button();
                yerler.Width = 30;
                yerler.Height = 40;
                yerler.BackColor = Color.White;
                yerler.Font = new Font(yerler.Font.Name, yerler.Font.Size, FontStyle.Italic);
                yerler.Left = left;
                yerler.Top = top;
                yerler.Text = count.ToString();
                Controls.Add(yerler);
                left += 40;
                count++;
                yerler.Click += new System.EventHandler(this.sechmek);
            }
        }
        private void sechmek(object sender, EventArgs arguments)
        {
            Button yerim = sender as Button;
            yerim.BackColor = Color.Yellow;
            yerler.Add(yerim);
            foreach (var duyme in yerler)
            {
                duyme.Click += new System.EventHandler(this.clickkkk);
            }

        }
        private void clickkkk(object sender, EventArgs argumentss)
        {
            foreach (var yer in yerler)
            {
            }
        }

        private void ok_duyme_Click(object sender, EventArgs e)
        {
            ok_duyme.BackColor = Color.LightBlue;
            foreach (var yer in yerler)
            {
                yer.BackColor = Color.OrangeRed;
            }
        }
    }
}
