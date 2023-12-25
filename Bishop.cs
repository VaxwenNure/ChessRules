using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessRules
{
    class Bishop :ChessPiece
    {
        public override string Name => "Bishop";
        public override Image Image => Properties.Resources.Bishop;

        public override string Information => "Слон може ходити на будь-яку відстань, втім лише по діагоналях. Кожен слон починає гру на полі певного кольору (світлого або темного) і має завжди залишатися на клітинках цього кольору. ";

    }
}
