using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи:");
            var whiteRookPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию чёрного слона:");
            var blackBishopPosition = Console.ReadLine();

            if(whiteRookPosition == blackBishopPosition)
            {
                Console.WriteLine("Ладья и слон не могут стоять на одной клетке.");
                return;
            }

            int whiteRookHorizontal, whiteRookVertical;
            int blackBishopHorizontal, blackBishopVertical;

            DecodePosition(whiteRookPosition, out whiteRookVertical, out whiteRookHorizontal);
            DecodePosition(blackBishopPosition, out blackBishopVertical, out blackBishopHorizontal);

            if (whiteRookHorizontal < 1 || whiteRookHorizontal > 8 || whiteRookVertical > 8 || blackBishopHorizontal < 1 || blackBishopHorizontal > 8 || blackBishopVertical > 8)
            {
                Console.WriteLine("Позиции фигур введены некорректно.");
                return;
            }
            if ((blackBishopHorizontal % 2 != 0) & (blackBishopVertical % 2 == 0) || (blackBishopHorizontal % 2 == 0) & (blackBishopVertical % 2 != 0))
            {
                Console.WriteLine("Чёрный слон не может стоять на белой клетке.");
                return;
            }

            if (IsUnderStrikeByWhiteRook(blackBishopPosition, whiteRookPosition))
                Console.WriteLine("Слон находится под боем ладьи.");
            else if (IsUnderStrikeByBlackBishop(whiteRookPosition, blackBishopPosition))
                Console.WriteLine("Ладья находится под боем слона.");
            else
                Console.WriteLine("Фигуры не бьют друг друга.");
        }

        static void DecodePosition(string position, out int vert, out int hor)
        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position.Substring(1).ToString());
        }

        static bool IsUnderStrikeByWhiteRook(string position, string whiteRookPosition)
        {
            int positionVertical, positionHorizontal, whiteRookVertical, whiteRookHorizontal;

            DecodePosition(position, out positionVertical, out positionHorizontal);
            DecodePosition(whiteRookPosition, out whiteRookVertical, out whiteRookHorizontal);

            return positionVertical == whiteRookVertical || positionHorizontal == whiteRookHorizontal;
        }

        static bool IsUnderStrikeByBlackBishop(string position, string blackBishopPosition)
        {
            int positionVertical, positionHorizontal, blackBishopVertical, blackBishopHorizontal;

            DecodePosition(position, out positionVertical, out positionHorizontal);
            DecodePosition(blackBishopPosition, out blackBishopVertical, out blackBishopHorizontal);

            return Math.Abs(positionVertical - blackBishopVertical) >= 1 && blackBishopHorizontal == Math.Abs(positionVertical - blackBishopVertical + positionHorizontal) || Math.Abs(blackBishopVertical - positionVertical) >= 1 && blackBishopHorizontal == Math.Abs(blackBishopVertical - positionVertical + positionHorizontal);
        }
    }
}
