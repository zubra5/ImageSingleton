using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSingleton
{
    public partial class MainForm : Form
    {
        public Picture pic { get; set; }

        public MainForm()
        {
            InitializeComponent();
            pic = Picture.Instance;
            this.Controls.Add(pic);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pic);
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            this.Controls.Add(pic);
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            SecondForm frm = new SecondForm(true);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm frm = new SecondForm(false);
            frm.Show();
        }
    }
}
