using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_a_screenshot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(MyPanel.Width,MyPanel.Height))
            {
                MyPanel.DrawToBitmap(bmp, new Rectangle(0,0,bmp.Width,bmp.Height));
                bmp.Save(@"ScreenShots/" +ImageName.Text+ ".bmp");
            }

        }
    }
}
