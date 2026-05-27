using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers.UnitTests
{
    [TestFixture]
    public class ComplexTrUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var complex = new ComplexTr(2.5, Math.PI);

            Assert.That(complex.Abs, Is.EqualTo(2.5));
            Assert.That(complex.Arg, Is.EqualTo(Math.PI));
        }

        [Test]
        public void Constructor_NegativeAbs_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ComplexTr(-1.0, 0));
        }

        [Test]
        public void Equals_WrongArgument_ArgumentException()
        {
            var complex = new ComplexTr(2.5, Math.PI);
            var smth = new object();

            Assert.That(() => complex.Equals(smth), Throws.ArgumentException);
        }

        [Test]
        public void ReAndIm_CalculatedCorrectly()
        {
            var complex = new ComplexTr(2.0, Math.PI / 3);

            //cos(60) = 0.5, sin(60) = sqrt(3)/2
            Assert.That(complex.Re, Is.EqualTo(1.0).Within(1e-13));
            Assert.That(complex.Im, Is.EqualTo(Math.Sqrt(3)).Within(1e-13));
        }

        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            var zero = new ComplexTr(0, 5.0);
            var one = new ComplexTr(1, 1.5);
            var normal = new ComplexTr(2.5, 3.7);

            string argOne = 1.5.ToString();
            string argNorm = 3.7.ToString();
            string absNorm = 2.5.ToString();

            Assert.That(zero.ToString(), Is.EqualTo("0"));
            Assert.That(one.ToString(), Is.EqualTo($"cos({argOne}) + i sin({argOne})"));
            Assert.That(normal.ToString(), Is.EqualTo($"{absNorm}(cos({argNorm}) + i sin({argNorm}))"));
        }

        [Test]
        public void Equals_EqualNumbers_ReturnsTrue()
        {
            var c1 = new ComplexTr(2.0, 1.5);
            var c2 = new ComplexTr(2.0, 1.5 + 2 * Math.PI);
            var c3 = new ComplexTr(0, 1.0);
            var c4 = new ComplexTr(0, 2.0);

            Assert.That(c1.Equals(c2), Is.True);
            Assert.That(c1 == c2, Is.True);
            Assert.That(c3 == c4, Is.True);
        }

        [Test]
        public void Equals_DifferentNumbers_ReturnsFalse()
        {
            var c1 = new ComplexTr(2.0, 1.5);
            var c2 = new ComplexTr(3.0, 1.5);
            var c3 = new ComplexTr(2.0, 1.6);

            Assert.That(c1.Equals(c2), Is.False);
            Assert.That(c1 != c3, Is.True);
        }

        [Test]
        public void GetHashCode_EqualNumbers_ReturnSameHash()
        {
            var c1 = new ComplexTr(2.0, 1.5);
            var c2 = new ComplexTr(2.0, 1.5 + 2 * Math.PI);

            Assert.That(c1.GetHashCode(), Is.EqualTo(c2.GetHashCode()));
        }

        [Test]
        public void Multiplication_CalculatesCorrectly()
        {
            var c1 = new ComplexTr(2.0, Math.PI / 4);
            var c2 = new ComplexTr(3.0, Math.PI / 2);
            var result = c1 * c2;

            Assert.That(result.Abs, Is.EqualTo(6.0).Within(1e-13));
            Assert.That(result.Arg, Is.EqualTo(3 * Math.PI / 4).Within(1e-13));
        }

        [Test]
        public void Division_CalculatesCorrectly()
        {
            var c1 = new ComplexTr(6.0, Math.PI);
            var c2 = new ComplexTr(2.0, Math.PI / 4);
            var result = c1 / c2;

            Assert.That(result.Abs, Is.EqualTo(3.0).Within(1e-13));
            Assert.That(result.Arg, Is.EqualTo(3 * Math.PI / 4).Within(1e-13));
        }

        [Test]
        public void Division_ByZero_ThrowsDivideByZeroException()
        {
            var c1 = new ComplexTr(6.0, Math.PI);
            var c2 = new ComplexTr(0, 0);

            Assert.Throws<DivideByZeroException>(() => { var r = c1 / c2; });
        }
    }
}