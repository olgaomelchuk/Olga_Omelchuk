using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.UnitTests
{
    [TestFixture]
    public class PillsUnitTests
    {
        [Test]
        public void PillsConstructorTest()
        {
            var pills = new Pills("456-DEF", "Аспирин", MedicineRelease.WithoutPrescription, "Bayer", 20);

            Assert.That(pills.Article, Is.EqualTo("456-DEF"));
            Assert.That(pills.Name, Is.EqualTo("Аспирин"));
            Assert.That(pills.Release, Is.EqualTo(MedicineRelease.WithoutPrescription));
            Assert.That(pills.Manufacturer, Is.EqualTo("Bayer"));
            Assert.That(pills.QuantityInPackage, Is.EqualTo(20));
            Assert.That(pills.Price, Is.EqualTo(0));
            Assert.That(pills.StockQuantity, Is.EqualTo(0));
        }

        [Test]
        public void PillsGetInfoTest()
        {
            var pills = new Pills("456-DEF", "Аспирин", MedicineRelease.WithoutPrescription, "Bayer", 20);

            var info = pills.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Артикул: 456-DEF. Название: Аспирин."));
            Assert.That(info[1], Is.EqualTo("Отпуск: Отпускается без рецепта. Производитель: Bayer. Цена: 0. Кол-во на складе: 0 шт."));
            Assert.That(info[2], Is.EqualTo("Форма выпуска: Таблетки. Количество в упаковке: 20 шт."));
        }
    }
}
