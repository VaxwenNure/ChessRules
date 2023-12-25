using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChessRules
{
    public class ChessPiece
    {
        public virtual string Name { get; } // Назва фігури
        public virtual Image Image { get; } // Зображення фігури
        public virtual string Information { get; } // Назва фігури
        public virtual void Move()
        {
            MessageBox.Show($"Хід фігури: {Name}");
        }
    }
}
