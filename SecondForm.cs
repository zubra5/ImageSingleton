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
    public partial class SecondForm : Form
    {
        public Picture pic { get; set; }
        public SecondForm()
        {
            InitializeComponent();

        }

        public SecondForm(bool isShowedPicture)
        {
            InitializeComponent();
            if (isShowedPicture)
            {
                pic = Picture.Instance;
                this.Controls.Add(pic);
            }
        }
    }
}
