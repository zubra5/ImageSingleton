using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSingleton
{
    public partial class Picture : UserControl
    {
        static Lazy<Picture> instance
        {
            get
            {
                var pic= new Lazy<Picture>();
                pic.Value.InitializeComponent();
                return pic;
            }
        }
        public Picture()
        {
            //InitializeComponent();
        }

        public static Picture Instance
        {
            get
            {
                return instance.Value;
            }
        }

    }
}
