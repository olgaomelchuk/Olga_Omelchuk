namespace Pharmacy.UnitTests
{
    [TestFixture]
    public class MedicineUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var medicine = CreateTestMedicine();

            Assert.That(medicine.Article, Is.EqualTo("123-ABC"));
            Assert.That(medicine.Name, Is.EqualTo("Парацетамол"));
            Assert.That(medicine.Release, Is.EqualTo(MedicineRelease.WithoutPrescription));
            Assert.That(medicine.Manufacturer, Is.EqualTo("OZON"));

            Assert.That(medicine.Price, Is.EqualTo(0));
            Assert.That(medicine.StockQuantity, Is.EqualTo(0));
        }

        [Test]
        public void GetInfoTest()
        {
            var medicine = CreateTestMedicine();
            var info = medicine.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Артикул: 123-ABC. Название: Парацетамол."));
            Assert.That($"Отпуск: Отпускается без рецепта. Производитель: OZON. Цена: 0. Кол-во на складе: 0 шт.",
                Is.EqualTo(info[1]));
        }

        [Test]
        public void PriceAndStockQuantityTest()
        {
            var medicine = CreateTestMedicine();
            medicine.Price = 149.99m;
            medicine.StockQuantity = 134;

            Assert.That(medicine.Price, Is.EqualTo(149.99m));
            Assert.That(medicine.StockQuantity, Is.EqualTo(134));

            var info = medicine.GetInfo();
            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Артикул: 123-ABC. Название: Парацетамол."));
            Assert.That($"Отпуск: Отпускается без рецепта. Производитель: OZON. Цена: 149,99. Кол-во на складе: 134 шт.",
                Is.EqualTo(info[1]));
        }

        [Test]
        public void Price_ShouldThrowException_WhenNegative()
        {
            var medicine = CreateTestMedicine();

            Assert.Throws<ArgumentException>(() =>
            {
                medicine.Price = -1;
            });
        }

        [Test]
        public void StockQuantity_ShouldThrowException_WhenNegative()
        {
            var medicine = CreateTestMedicine();

            Assert.Throws<ArgumentException>(() =>
            {
                medicine.StockQuantity = -1;
            });
        }

        private Medicine CreateTestMedicine()
        {
            return new Medicine("123-ABC", "Парацетамол", MedicineRelease.WithoutPrescription, "OZON");
        }
    }
}