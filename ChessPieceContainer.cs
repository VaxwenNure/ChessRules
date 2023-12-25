using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessRules
{
    public class ChessPieceContainer
    {
        private List<ChessPiece> chessPieces = new List<ChessPiece>();

        public void AddChessPiece(ChessPiece piece)
        {
            chessPieces.Add(piece);
        }

        public void RemoveChessPiece(ChessPiece piece)
        {
            chessPieces.Remove(piece);
        }

        public void DisplayInformation()
        {
            foreach (var piece in chessPieces)
            {
                MessageBox.Show($"Ім'я фігури: {piece.Name}");
            }
        }
        public ChessPiece CreateChessPiece(string pieceName)
        {
            switch (pieceName)
            {
                case "King":
                    return new King();
                case "Queen":
                    return new Queen();
                case "Pawn":
                    return new Pawn();
                case "Rook":
                    return new Rook();
                case "Bishop":
                    return new Bishop();
                case "Knight":
                    return new Knight();
                default:
                    throw new ArgumentException("Невірна назва фігури");
            }
        }
    }
}
