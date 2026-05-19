using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.UnitTests
{
    [TestFixture]
    public class OintmentUnitTests
    {
        [Test]
        public void OintmentConstructorTest()
        {
            var ointment = new Ointment("012-JKL", "Левомеколь", MedicineRelease.WithPrescription, "Nizhpharm", 40);

            Assert.That(ointment.Article, Is.EqualTo("012-JKL"));
            Assert.That(ointment.Name, Is.EqualTo("Левомеколь"));
            Assert.That(ointment.Release, Is.EqualTo(MedicineRelease.WithPrescription));
            Assert.That(ointment.Manufacturer, Is.EqualTo("Nizhpharm"));
            Assert.That(ointment.TubeVolume, Is.EqualTo(40));
            Assert.That(ointment.Price, Is.EqualTo(0));
            Assert.That(ointment.StockQuantity, Is.EqualTo(0));
        }

        [Test]
        public void Ointment_GetInfoTest()
        {
            var ointment = new Ointment("012-JKL", "Левомеколь", MedicineRelease.WithPrescription, "Nizhpharm", 40);

            var info = ointment.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Артикул: 012-JKL. Название: Левомеколь."));
            Assert.That(info[1], Is.EqualTo("Отпуск: Отпускается по рецепту. Производитель: Nizhpharm. Цена: 0. Кол-во на складе: 0 шт."));
            Assert.That(info[2], Is.EqualTo("Форма выпуска: Мазь. Объем тубы: 40 мг."));
        }
    }
}