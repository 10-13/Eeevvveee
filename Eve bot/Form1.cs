using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using User32Interface;

namespace Eve_bot
{
    public partial class Form1 : Form
    {
        private System.Diagnostics.Process procs = System.Diagnostics.Process.GetProcesses().FirstOrDefault(new Func<Process, bool>((Process f) => { return f.ProcessName.ToLower().Contains("nox") && f.MainWindowHandle != IntPtr.Zero;  }));
        private IntPtr handle;

        public Bitmap screen = new Bitmap(950, 540);
        public Dictionary<string, Point> targets = new Dictionary<string, Point>();
        protected Graphics g;

        public event Action OnAlgoTick;

        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromImage(screen);
            handle = procs.MainWindowHandle;
            OnAlgoTick += UpdateSheild;
            OnAlgoTick += UpdateArmor;
        }

        private int Diffrence(Color a)
        {
            int _a = ((a.R + a.G) / 2 - a.B),_b  = ((a.G + a.B) / 2 - a.R),_c = ((a.B + a.R) / 2 - a.G);
            return Math.Max(_a, Math.Max(_b, _c));
        }

        private void UpdateSheild()
        {
            int res = 0;
            for (int i = 100; i > -1; i--)
                if (targets.ContainsKey("SHEILD_" + i.ToString()))
                    if (Diffrence(screen.GetPixel(targets["SHEILD_" + i.ToString()].X, targets["SHEILD_" + i.ToString()].Y)) > 10)
                        res = i;
                    else
                    {
                        SheildHP.Value = i;
                        return;
                    }
            SheildHP.Value = res;
        }
        private void UpdateArmor()
        {
            int res = 0;
            for (int i = 100; i > -1; i--)
                if (targets.ContainsKey("ARMOR_" + i.ToString()))
                    if (Diffrence(screen.GetPixel(targets["ARMOR_" + i.ToString()].X, targets["ARMOR_" + i.ToString()].Y)) > 10)
                        res = i;
                    else
                    {
                        ArmorHP.Value = i;
                        return;
                    }
            ArmorHP.Value = res;
        }

        private void UpdateTicker_Tick(object sender, EventArgs e)
        {
            Rectangle bounds = WindowHandling.GetWindowBounds(handle);
            WindowHandling.SetAsForegroundWindow(handle);
            g.CopyFromScreen(bounds.X + 2, bounds.Y + 32, 0, 0, screen.Size);
            OnAlgoTick();
            if (!AlgorithmWorking.Checked)
                UpdateTicker.Stop();
        }

        private void AlgorithmWorking_CheckedChanged(object sender, EventArgs e)
        {
            if(AlgorithmWorking.Checked)
            {
                UpdateTicker.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle bounds = WindowHandling.GetWindowBounds(handle);
            WindowHandling.SetAsForegroundWindow(handle);
            g.CopyFromScreen(bounds.X + 2, bounds.Y + 32, 0, 0, screen.Size);
            PointAdding f = new PointAdding(screen, targets);
            f.Show();
        }
    }
}