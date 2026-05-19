using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Ointment : Medicine
    {
        public int TubeVolume { get; set; }

        public Ointment(string article, string name, MedicineRelease release, string manufacturer, int tubeVolume)
            : base(article, name, release, manufacturer)
        {
            TubeVolume = tubeVolume;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            var baseInfo = base.GetInfo();

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = $"Форма выпуска: Мазь. Объем тубы: {TubeVolume} мг.";

            return info;
        }
    }
}
