using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessRules
{
    class Knight : ChessPiece
    {
        public override string Name => "Knight";
        public override Image Image => Properties.Resources.Knight;
        public override string Information => "Коні ходять зовсім по-іншому, ніж всі фігури - дві клітинки в одному напрямку і ще одна під кутом 90 градусів, як форма літери Г. Кінь-єдина фігура, яка може ходити через інші фігури. ";
    }
}
