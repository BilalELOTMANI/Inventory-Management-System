using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class CustomerButton : PictureBox
    {
        public CustomerButton()
        {
            InitializeComponent();
        }

        private void CustomerButton_Load(object sender, EventArgs e)
        {

        }

        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return ImageNormal; }
            set { ImageNormal = value;}
        }

        public Image ImageHover
        {
            get { return ImageHover; }
            set { ImageHover = value; }
        }

        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }
    }
}
