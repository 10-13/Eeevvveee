using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User32Interface
{
    public class UserEmu
    {
        // -- STATIC -------------------------------
        public static float DelayMult = 1;
        public static float BaseDelay = 0;
        public static int   DelayVariation = 0;
        public static float DelayVariationMult = 0;

        /// <summary>
        /// First layer randomizing element (declarates static diapzones to delay variation)
        /// </summary>
        public enum DelayMode
        {
            Click =         0x00000100,
            Hold =          0x00011000,
            DoubleClick =   0x00000011,
            LongClick =     0x01010000
        }

        public static int GetDelay(DelayMode mode, bool GenerateBaseDelay = true,bool UseSecondLayerRandomizing = true,float AdditionalDelay = 0)
        {
            Random random = new Random(DateTime.Now.Year - DateTime.Now.Day + DateTime.Now.Millisecond - DateTime.Now.Second);
            float ResDelay = random.Next(((int)mode) * 2) - (int)mode;
            if(GenerateBaseDelay)
                ResDelay += BaseDelay;
            if (UseSecondLayerRandomizing)
                ResDelay += (random.Next(DelayVariation * 2) - (int)mode) * DelayVariationMult;
            ResDelay *= DelayMult;
            ResDelay += AdditionalDelay;
            return (int)ResDelay;
        }
        // -- DYNAMIC ------------------------------
    }

}
