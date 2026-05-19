using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Pills : Medicine
    {
        public int QuantityInPackage { get; set; }

        public Pills(string article, string name, MedicineRelease release, string manufacturer, int quantityInPackage)
            : base(article, name, release, manufacturer)
        {
            QuantityInPackage = quantityInPackage;
        }

        public override string[] GetInfo()
        {
            var info = new string[3];

            var baseInfo = base.GetInfo();
            info[0] = baseInfo[0];
            info[1] = baseInfo[1];

            info[2] = $"Форма выпуска: Таблетки. Количество в упаковке: {QuantityInPackage} шт.";
            return info;
        }
    }
}
