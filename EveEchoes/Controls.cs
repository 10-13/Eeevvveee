using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = System.Drawing.Point;

using EveEchoes.VisualUpdating;

namespace EveEchoes
{
    public enum ControlType
    {
        Sheild,
        Armor,
        Hull,
        Energy,
        Speed,
        Panel,
        Targeting,
        Weapon,
        Harderer,
        EWarfare,
        Capacitor,
        InvinsebleAdaptive,
        InvinsebleReactive,
        Drive
    }
    public enum CountebleType
    {
        Procentage000,
        Procentage010,
        Procentage020,
        Procentage030,
        Procentage040,
        Procentage050,
        Procentage060,
        Procentage070,
        Procentage080,
        Procentage090,
        Procentage100
    }
    public enum Panel
    {
        Selector,
        Anomaly,
        Stations,
        FirstElement,
        WarpStation,
        WarpAnomaly
    }
    public enum TargetingType
    {
        LockAll
    }
    public enum WeaponType
    {
        Dron,
        MainWeapon
    }
    public enum DefenseType
    {
        Sheild,
        Armor
    }
    public enum EWarfare
    {
        StasisInductor,
        Noseferator,
        Neutralizer
    }
    public enum Capacitor
    {
        Booster
    }
    public enum DriveType
    {
        MicroWarp,
        Afterburner
    }

    public struct AutoType
    {
        public ControlType ControlType;
        public Type SecondEnumType;
        public object SecondType;
        public AutoType(ControlType type,Type SecondEnumType,object SecondType)
        {
            ControlType = type;
            this.SecondEnumType = SecondEnumType;
            this.SecondType = SecondType;  
        }
        public override string ToString()
        {
            if(SecondEnumType == null)
                return ControlType.ToString();
            return ControlType.ToString() + " " + SecondType.ToString();
        }
        public static AutoType Build<T>(ControlType type,T SecondType)
        {
            return new AutoType(type,typeof(T), SecondType);
        }
    }

    class Controls : IVisualControlsTargetSource
    {
        public List<KeyValuePair<AutoType, Point>> Points { get; protected set; } = new List<KeyValuePair<AutoType, Point>>();

        public bool ContainsPoint(string name)
        {
            return Points.Any(new Func<KeyValuePair<AutoType, Point>,bool>((KeyValuePair<AutoType, Point> t) => { return t.Key.ToString() == name; }));
        }

        public Point GetPointByName(string name)
        {
            return Points.FirstOrDefault(new Func<KeyValuePair<AutoType, Point>, bool>((KeyValuePair<AutoType, Point> t) => { return t.Key.ToString() == name; })).Value;
        }

        public void RemovePointByName(string name)
        {
            if (ContainsPoint(name))
                Points.Remove(Points.FirstOrDefault(new Func<KeyValuePair<AutoType, Point>, bool>((KeyValuePair<AutoType, Point> t) => { return t.Key.ToString() == name; })));
        }
    }
}
