using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.UnitTests
{
    [TestFixture]
    public class MixtureUnitTests
    {
        [Test]
        public void MixtureConstructorTest()
        {
            var mixture = new Mixture("789-GHI", "Сироп от кашля", MedicineRelease.WithoutPrescription, "Dr.Theiss", 100);

            Assert.That(mixture.Article, Is.EqualTo("789-GHI"));
            Assert.That(mixture.Name, Is.EqualTo("Сироп от кашля"));
            Assert.That(mixture.Release, Is.EqualTo(MedicineRelease.WithoutPrescription));
            Assert.That(mixture.Manufacturer, Is.EqualTo("Dr.Theiss"));
            Assert.That(mixture.BottleVolume, Is.EqualTo(100));
            Assert.That(mixture.Price, Is.EqualTo(0));
            Assert.That(mixture.StockQuantity, Is.EqualTo(0));
        }

        [Test]
        public void MixtureGetInfoTest()
        {
            // Arrange
            var mixture = new Mixture("789-GHI", "Сироп от кашля", MedicineRelease.WithoutPrescription, "Dr.Theiss", 100);

            // Act
            var info = mixture.GetInfo();

            // Assert
            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Артикул: 789-GHI. Название: Сироп от кашля."));
            Assert.That(info[1], Is.EqualTo("Отпуск: Отпускается без рецепта. Производитель: Dr.Theiss. Цена: 0. Кол-во на складе: 0 шт."));
            Assert.That(info[2], Is.EqualTo("Форма выпуска: Микстура. Объем бутылки: 100 мл."));
        }
    }
}