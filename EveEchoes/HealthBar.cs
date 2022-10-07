using EveEchoes.VisualUpdating;

namespace EveEchoes
{
    public class HealthBar
    {
        public int Sheild
        { 
            get { return Sheild;}
            set { Sheild = value; OnSheildChanged(); }
        }
        public int Armor
        {
            get { return Armor; }
            set { Armor = value; OnArmorChanged(); }
        }
        public int Hull
        {
            get { return Hull; }
            set { Hull = value; OnHullChanged(); }
        }

        event Action OnSheildChanged;
        event Action OnArmorChanged;
        event Action OnHullChanged;

        public HealthBar()
        {
            Sheild = 100;
            Armor = 100;
            Hull = 100;
        }

        public void Update(in IVisualControlsTargetSource source,in IVisualTarget target)
        {
            int Sheild = 0;
            foreach (CountebleType c in typeof(CountebleType).GetEnumValues())
                if (source.ContainsPoint(AutoType.Build(ControlType.Sheild, c).ToString()))
                    if (Visual.GetDiffrenc(target.GetPointColor(source.GetPointByName(AutoType.Build(ControlType.Sheild, c).ToString()))) < 10)
                        if (int.TryParse(c.ToString().Substring(c.ToString().Length - 3), out int res))
                            if (Sheild < res)
                                Sheild = res;
            
            int Armor = 0;
            foreach (CountebleType c in typeof(CountebleType).GetEnumValues())
                if (source.ContainsPoint(AutoType.Build(ControlType.Armor, c).ToString()))
                    if (Visual.GetDiffrenc(target.GetPointColor(source.GetPointByName(AutoType.Build(ControlType.Armor, c).ToString()))) < 10)
                        if (int.TryParse(c.ToString().Substring(c.ToString().Length - 3), out int res))
                            if (Sheild < res)
                                Sheild = res;
            if (this.Sheild != Sheild)
                this.Sheild = Sheild;
            if (this.Armor != Armor)
                this.Armor = Armor;
        }
    }
}