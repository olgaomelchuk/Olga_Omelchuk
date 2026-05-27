using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public struct ComplexTr
    {
        private const double Epsilon = 1e-13;

        private double _abs;

        public double Abs
        {
            get => _abs;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Модуль числа не может быть отрицательным.");
                _abs = value;
            }
        }

        public double Arg { get; set; }

        public double Re => Abs * Math.Cos(Arg);

        public double Im => Abs * Math.Sin(Arg);

        public ComplexTr(double abs, double arg)
        {
            this = new ComplexTr();
            Abs = abs;
            Arg = arg;
        }

        public override string ToString()
        {
            //Если модуль равен 0, то всё число - это 0
            if (Abs < Epsilon)
                return "0";

            string argStr = Arg.ToString();
            string trigPart = $"cos({argStr}) + i sin({argStr})";

            //Если модуль равен 1, мы его не пишем и скобки вокруг не ставим
            if (Math.Abs(Abs - 1) < Epsilon)
                return trigPart;

            //Обычный вид
            return $"{Abs}({trigPart})";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ComplexTr))
                throw new ArgumentException("Объект для сравнения не является комплексным числом в тригонометрической форме");

            ComplexTr other = (ComplexTr)obj;

            //Сравниваем модули
            if (Math.Abs(Abs - other.Abs) > Epsilon)
                return false;

            //Если модули равны 0, то числа равны независимо от их аргументов
            if (Abs < Epsilon)
                return true;

            //Разность аргументов должна быть кратна 2Пи
            double diff = Math.Abs(Arg - other.Arg);
            double mod = diff % (2 * Math.PI);

            //Остаток от деления на 2Пи должен быть либо очень близок к 0, либо к 2Пи
            return mod < Epsilon || Math.Abs(mod - 2 * Math.PI) < Epsilon;
        }

        public override int GetHashCode()
        {
            if (Abs < Epsilon)
                return 0;

            return Math.Round(Re, 12).GetHashCode() ^ Math.Round(Im, 12).GetHashCode();
        }

        public static bool operator ==(ComplexTr a, ComplexTr b) => a.Equals(b);
        public static bool operator !=(ComplexTr a, ComplexTr b) => !a.Equals(b);

        //Операция умножения
        public static ComplexTr operator *(ComplexTr a, ComplexTr b)
        {
            //Модули умножаются, аргументы складываются
            return new ComplexTr(a.Abs * b.Abs, a.Arg + b.Arg);
        }

        //Операция деления
        public static ComplexTr operator /(ComplexTr a, ComplexTr b)
        {
            if (b.Abs < Epsilon)
                throw new DivideByZeroException("Деление на ноль запрещено (модуль делителя равен 0).");

            //Модули делятся, аргументы вычитаются
            return new ComplexTr(a.Abs / b.Abs, a.Arg - b.Arg);
        }
    }
}