using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessRules
{
    class Pawn : ChessPiece
    {
        public override string Name => "Pawn";
        public override Image Image => Properties.Resources.Pawn;
        public override string Information => $"Пішаки незвичні, тому що вони ходять і б'ють фігури різними шляхами: вони рухаються вперед, \n але б'ють фігури по діагоналі. Пішаки можуть лише ходити вперед на одну клітинку, за виключенням їхнього першого ходу, коли вони можуть ходити вперед на дві клітинки. Пішаки можуть бити фігури лише на одну клітинку по діагоналі перед ними. Вони ніколи не можуть ходити або бити фігури назад. Якщо є інша фігура прямо перед пішаком він не може ходити повз чи бити ту фігуру. ";
    }
}
