using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Medicine
    {
        public readonly string Article;
        public string Name { get; set; }
        public MedicineRelease Release;
        public string Manufacturer { get; set; }

        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Неверный формат цены.");
                price = value;
            }
        }

        private int stockQuantity;
        public int StockQuantity
        {
            get => stockQuantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Неверный формат количества.");
                stockQuantity = value;
            }
        }

        public Medicine(string article, string name, MedicineRelease release, string manufacturer)
        {
            Article = article;
            Name = name;
            Release = release;
            Manufacturer = manufacturer;

            Price = 0;
            StockQuantity = 0;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"Артикул: {Article}. Название: {Name}.";

            string release;
            if (Release == MedicineRelease.WithPrescription)
                release = "Отпускается по рецепту";
            else
                release = "Отпускается без рецепта";

            info[1] = $"Отпуск: {release}. Производитель: {Manufacturer}. Цена: {Price}. Кол-во на складе: {StockQuantity} шт.";
            return info;
        }
    }
}
