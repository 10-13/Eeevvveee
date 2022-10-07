using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EveEchoes.VisualUpdating
{
    public static class Visual
    {
        public static int GetDiffrenc(Color a)
        {
            int _a = ((a.R + a.G) / 2 - a.B), _b = ((a.G + a.B) / 2 - a.R), _c = ((a.B + a.R) / 2 - a.G);
            return Math.Max(_a, Math.Max(_b, _c));
        }
    }
    public interface IVisualTarget
    {
        public Color GetPointColor(Point point);
    }
   
    public interface IVisualControlsTargetSource
    {
        public List<KeyValuePair<AutoType,Point>> Points { get; }

        public Point GetPointByName(string name);
        public bool ContainsPoint(string name);
        public void RemovePointByName(string name);
    }
}
