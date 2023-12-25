using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessRules
{
    class Queen : ChessPiece
    {
        public override string Name => "Queen";
        public override Image Image => Properties.Resources.Queen;
        public override string Information => "Вона може ходити прямо в одному напрямку: вперед, назад, вбік або по діагоналі. ";
    }
}