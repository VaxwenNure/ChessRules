using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ChessRules
{
    class King : ChessPiece
    {
        public override string Name => "King";
        public override Image Image => Properties.Resources.King;

        public override string Information => "Король може ходити лише на одну клітинку у будь-якому напрямку: вгору, вниз, вбік та по діагоналі. ";

    }
}
