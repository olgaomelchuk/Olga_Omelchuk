using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.UnitTests
{
    [TestFixture]
    public class PharmacyStoreUnitTests
    {
        private PharmacyStore store;
        private Medicine[] medicinesArray;

        [SetUp]
        public void Setup()
        {
            var med1 = new Medicine("001", "Аспирин", MedicineRelease.WithoutPrescription, "Bayer");
            var med2 = new Medicine("002", "Нурофен", MedicineRelease.WithoutPrescription, "Reckitt");
            var med3 = new Medicine("003", "Левомеколь", MedicineRelease.WithPrescription, "Nizhpharm");

            //Проверяем, что одинаковые лекарства (med1) не добавятся в массив
            medicinesArray = new Medicine[] { med1, med2, med3, med1 };

            store = new PharmacyStore("Аптека Плюс", "ул. Ленина, 10", medicinesArray);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(store.Title, Is.EqualTo("Аптека Плюс"));
            Assert.That(store.Address, Is.EqualTo("ул. Ленина, 10"));
        }

        [Test]
        public void CountTest()
        {
            //Так как med1 повторялся в массиве, уникальных должно быть 3
            Assert.That(store.Count, Is.EqualTo(3));
        }

        [Test]
        public void IEnumerableTest()
        {
            int i = 0;
            foreach (var medicine in store)
            {
                Assert.That(medicine, Is.SameAs(medicinesArray.Distinct().ElementAt(i)));
                i++;
            }
            Assert.That(i, Is.EqualTo(3));
        }
    }
}
