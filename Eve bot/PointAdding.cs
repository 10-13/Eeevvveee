using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eve_bot
{
    public partial class PointAdding : Form
    {
        protected Dictionary<string, Point> endPoint;

        public PointAdding()
        {
            InitializeComponent();
        }
        public PointAdding(in Bitmap target,in Dictionary<string,Point> output)
        {   
            InitializeComponent();
            this.ClientSize = target.Size;
            this.BackgroundImage = target;
            endPoint = output;
        }

        private void PointAdding_Load(object sender, EventArgs e)
        {

        }

        private void PointAdding_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
            TextInput f = new TextInput("Input point validation key:");
            if(f.ShowDialog() == DialogResult.OK)
            {
                if (endPoint.ContainsKey(f.Text))
                    endPoint[f.Text] = point;
                else
                    endPoint.Add(f.Text,point);
            }
        }
    }
}
