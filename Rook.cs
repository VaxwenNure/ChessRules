using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessRules
{
    class Rook : ChessPiece
    {
        public override string Name => "Rook";
        public override Image Image => Properties.Resources.Rook;
        public override string Information => "Тура може пересуватися тільки вперед, назад і в сторони. ";
    }
}
