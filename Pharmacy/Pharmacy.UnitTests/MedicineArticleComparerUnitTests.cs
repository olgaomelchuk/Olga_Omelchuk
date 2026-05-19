using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.UnitTests
{
    [TestFixture]
    public class MedicineArticleComparerUnitTests
    {
        [Test]
        public void CompareTestByArticle()
        {
            var comparer = new MedicineArticleComparer();
            var medA = new Medicine("AAA-123", "Препарат1", MedicineRelease.WithoutPrescription, "Завод");
            var medB = new Medicine("BBB-456", "Препарат2", MedicineRelease.WithoutPrescription, "Завод");

            Assert.That(comparer.Compare(medA, medB), Is.LessThan(0)); //AAA меньше BBB
            Assert.That(comparer.Compare(medB, medA), Is.GreaterThan(0)); //BBB больше AAA
            Assert.That(comparer.Compare(medA, medA), Is.EqualTo(0)); //Одинаковые равны
        }
    }
}
