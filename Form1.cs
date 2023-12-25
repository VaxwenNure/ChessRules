using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChessRules
{
    public partial class Form1 : Form
    {
        private ChessPieceContainer container = new ChessPieceContainer();

        public Form1()
        {
            InitializeComponent();

        }
        private void showButton_Click_1(object sender, EventArgs e)
        {
            string selectedPiece = pieceSelector.SelectedItem?.ToString();

            if (selectedPiece != null)
            {

                ChessPiece piece = container.CreateChessPiece(selectedPiece);
                pictureBox_Screen.Image = piece.Image;
                textBox_Information.Text = piece.Information; 
                container.AddChessPiece(piece);
                container.DisplayInformation();
                container.RemoveChessPiece(piece);
            }
        }

        
    }
}
