namespace ChessRules
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Screen = new System.Windows.Forms.PictureBox();
            this.showButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pieceSelector = new System.Windows.Forms.ComboBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Information = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_Title.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_Title.Location = new System.Drawing.Point(242, 25);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(532, 46);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Як ходять фігури в шахах?";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Screen
            // 
            this.pictureBox_Screen.Location = new System.Drawing.Point(37, 95);
            this.pictureBox_Screen.Name = "pictureBox_Screen";
            this.pictureBox_Screen.Size = new System.Drawing.Size(540, 540);
            this.pictureBox_Screen.TabIndex = 1;
            this.pictureBox_Screen.TabStop = false;
            // 
            // showButton
            // 
            this.showButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showButton.Location = new System.Drawing.Point(711, 216);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(232, 62);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click_1);
            // 
            // pieceSelector
            // 
            this.pieceSelector.FormattingEnabled = true;
            this.pieceSelector.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Pawn",
            "Rook",
            "Bishop",
            "Knight"});
            this.pieceSelector.Location = new System.Drawing.Point(690, 163);
            this.pieceSelector.Name = "pieceSelector";
            this.pieceSelector.Size = new System.Drawing.Size(273, 24);
            this.pieceSelector.TabIndex = 3;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Name.Location = new System.Drawing.Point(705, 115);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(220, 31);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Виберіть фігуру:";
            // 
            // textBox_Information
            // 
            this.textBox_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_Information.Location = new System.Drawing.Point(665, 318);
            this.textBox_Information.Multiline = true;
            this.textBox_Information.Name = "textBox_Information";
            this.textBox_Information.ReadOnly = true;
            this.textBox_Information.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Information.Size = new System.Drawing.Size(329, 300);
            this.textBox_Information.TabIndex = 5;
            this.textBox_Information.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Information.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 653);
            this.Controls.Add(this.textBox_Information);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pieceSelector);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.pictureBox_Screen);
            this.Controls.Add(this.label_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Screen;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox pieceSelector;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Information;
    }
}

