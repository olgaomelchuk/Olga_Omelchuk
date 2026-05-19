using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Mixture : Medicine
    {
        public int BottleVolume { get; set; }

        public Mixture(string article, string name, MedicineRelease release, string manufacturer, int bottleVolume)
            : base(article, name, release, manufacturer)
        {
            BottleVolume = bottleVolume;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];
            var baseInfo = base.GetInfo();

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = $"Форма выпуска: Микстура. Объем бутылки: {BottleVolume} мл.";

            return info;
        }
    }
}
