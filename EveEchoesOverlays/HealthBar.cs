using EveEchoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveEchoesOverlays
{
    public partial class HealthBarElement : UserControl
    {

        HealthBar hp = null;
        

        public HealthBarElement()
        {
            InitializeComponent();
        }
        public HealthBarElement(in HealthBar f)
        {
            hp = f;
            InitializeComponent();
        }

        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(toolStripTextBox1.Text, out int k))
                update_timer.Interval = k;
            else
                toolStripTextBox1.Text = update_timer.Interval.ToString();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateHP()
        {
            Graphics g = CreateGraphics();
            Brush f = new LinearGradientBrush(new Point(0, 0), new Point(Width, 0), Color.FromArgb(255, 25, 25, 50), Color.FromArgb(255, 40, 40, 65));
            g.FillRectangle(f, new Rectangle(new Point(0, 0), Bounds.Size));
            float shpp = hp.Sheild / 100;
            float ahpp = hp.Armor / 100;
            float hhpp = hp.Hull / 100;

        }
    }
}
